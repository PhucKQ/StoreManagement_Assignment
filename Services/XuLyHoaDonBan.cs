using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class XuLyHoaDonBan : IXuLyHoaDon
    {
        private ILuuTruHoaDon luuTruHoaDonBan;
        private ILuuTruHoaDon luuTruHoaDonNhap;
        
        public XuLyHoaDonBan()
        {
            luuTruHoaDonBan = new LuuTruHoaDonBan();
            luuTruHoaDonNhap = new LuuTruHoaDonNhap();
        }
        
        public HoaDon DocMaHoaDon(string maHD)
        {
            List<HoaDon> dsHD = luuTruHoaDonBan.DocDanhSachHoaDon();
            foreach(HoaDon item in dsHD)
            {
                if(item.MaHoaDon == maHD)
                {
                    return item;
                }
            }

            return null;
        }

        public ServiceResult<bool> SuaHoaDon
            (string maHD, string tenMH, string ngayTao, int soLuong)
        {
            DateTime date = ConvertDateString(ngayTao);
            if (string.IsNullOrWhiteSpace(tenMH) ||
                string.IsNullOrWhiteSpace(ngayTao))
            {
                return new(false, false, "Dữ liệu nhập vào bị trống");
            }
            else if (soLuong <= 0)
            {
                return new(false, false, "Số lượng nhập vào không hợp lệ");
            }
            else if (ConvertDateString(ngayTao) == new DateTime())
            {
                return new(false, false, "Ngày Tạo Hóa Đơn không đúng định dạng");
            }
            else if (NgayTaoHoaDonCoDiTruocThoiDiemTaoHoaDon(date))
            {
                return new(false, false, "Ngày Tạo Hóa Đơn không hợp lệ");
            }
            else if (LaySoLuongHangTonKho(tenMH, date) < soLuong) 
            {
                return new(false, false, "Số lượng hàng trong kho không đủ");
            }

            HoaDon editHD = new();
            editHD.MaHoaDon = maHD;
            editHD.TenMatHang = tenMH.ToUpper();
            editHD.NgayTao = ngayTao;
            editHD.SoLuong = soLuong;
            luuTruHoaDonBan.SuaHoaDon(editHD);

            return new(true, true, string.Empty);
        }

        public ServiceResult<bool> TaoMoiHoaDon
            (string maHD, string tenMH, string ngayTao, int soLuong)
        {
            DateTime date = ConvertDateString(ngayTao);
            if (string.IsNullOrWhiteSpace(maHD) ||
                string.IsNullOrWhiteSpace(tenMH) ||
                string.IsNullOrWhiteSpace(ngayTao))
            {
                return new(false, false, "Dữ liệu nhập vào bị trống");
            }
            else if(soLuong <= 0)
            {
                return new(false, false, "Số lượng nhập vào không hợp lệ");
            }
            else if(KiemTraMaHoaDonDaCo(maHD.ToUpper()))
            {
                return new(false, false, "Mã Hóa Đơn đã tồn tại");
            }
            else if(ConvertDateString(ngayTao) == new DateTime())
            {
                return new(false, false, "Ngày Tạo Hóa Đơn không đúng định dạng");
            }
            else if(NgayTaoHoaDonCoDiTruocThoiDiemTaoHoaDon(date))
            {
                return new(false, false, "Ngày Tạo Hóa Đơn vượt quá ngày hiện tại");
            }
            else if(LaySoLuongHangTonKho(tenMH, date) < soLuong)
            {
                return new(false, false, $"Số lượng hàng trong kho đến trước ngày {date.ToShortDateString()} không đủ");
            }
            
            HoaDon newHD = new(maHD.ToUpper(), tenMH.ToUpper(), ngayTao, soLuong);
            luuTruHoaDonBan.TaoMoiHD(newHD);

            return new(true, true, string.Empty);
        }

        public List<HoaDon> TimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                tuKhoa = string.Empty;
            }
            List<HoaDon> dsHD = luuTruHoaDonBan.DocDanhSachHoaDon();
            List<HoaDon> dsKQ = new();
            foreach(HoaDon item in dsHD)
            {
                if (item.TenMatHang.Contains(tuKhoa))
                {
                    dsKQ.Add(item);
                }
            }

            return dsKQ;
        }

        public void XoaHoaDon(string maHD)
        {
            luuTruHoaDonBan.XoaHoaDon(maHD);
        }

        public bool KiemTraMaHoaDonDaCo(string maHD)
        {
            List<HoaDon> dsHDXuat = luuTruHoaDonBan.DocDanhSachHoaDon();
            foreach(HoaDon item in dsHDXuat)
            {
                if(item.MaHoaDon == maHD)
                {
                    return true;
                }
            }

            return false;
        }

        public DateTime ConvertDateString(string dateString)
        {
            DateTime date;
            CultureInfo culture = new("vi-VN");
            try
            {
                date = DateTime.ParseExact(dateString, "dd/M/yyyy", culture);
            }
            catch (Exception)
            {
                date = new DateTime();
            }

            return date;
        }

        public bool NgayTaoHoaDonCoDiTruocThoiDiemTaoHoaDon(DateTime ngayTaoHoaDon)
        {
            int checkDate = DateTime.Compare(ngayTaoHoaDon, DateTime.Today);
            if(checkDate > 0)
            {
                return true;
            }

            return false;
        }

        private int LaySoLuongHangTonKho(string tenMH, DateTime ngayTaoHDBanHang)
        {
            int soLuongNhap = 0, soLuongBan = 0;
            List<HoaDon> dsHDNhap = luuTruHoaDonNhap.DocDanhSachHoaDon();
            List<HoaDon> dsHDBan = luuTruHoaDonBan.DocDanhSachHoaDon();
            
            // lấy tổng số lượng nhập
            foreach (HoaDon item in dsHDNhap)
            {
                DateTime ngayNhapHang = ConvertDateString(item.NgayTao);
                int checkDate = DateTime.Compare(ngayNhapHang, ngayTaoHDBanHang);
                if (item.TenMatHang == tenMH && checkDate < 0)
                {
                    soLuongNhap += item.SoLuong;
                }
            }
            // lấy tổng số lượng bán
            foreach (HoaDon item in dsHDBan)
            {
                DateTime ngayBanHang = ConvertDateString(item.NgayTao);
                int checkDate = DateTime.Compare(ngayBanHang, ngayTaoHDBanHang);
                if (item.TenMatHang == tenMH && checkDate < 0)
                {
                    soLuongBan += item.SoLuong;
                }
            }

            return soLuongNhap - soLuongBan;
        }

        public int CapNhatSoLuongHangTonKho(string tenMH, DateTime ngayCapNhat)
        {
            int soLuongTonKho = 0;
            List<HoaDon> dsHDBan = luuTruHoaDonBan.DocDanhSachHoaDon();
            foreach (HoaDon item in dsHDBan)
            {
                DateTime ngayTao = ConvertDateString(item.NgayTao);
                int checkDate = DateTime.Compare(ngayTao, ngayCapNhat);
                if (item.TenMatHang == tenMH && checkDate < 0)
                {
                    soLuongTonKho += item.SoLuong;
                }
            }

            return soLuongTonKho;
        }
    }
}
