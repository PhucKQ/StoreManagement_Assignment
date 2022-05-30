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
    public class XuLyHoaDonNhap : IXuLyHoaDon
    {
        private ILuuTruHoaDon luuTruHoaDonNhap;
        public XuLyHoaDonNhap()
        {
            luuTruHoaDonNhap = new LuuTruHoaDonNhap();
        }
        public HoaDon DocMaHoaDon(string maHD)
        {
            List<HoaDon> dsHD = luuTruHoaDonNhap.DocDanhSachHoaDon();
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
            if (string.IsNullOrWhiteSpace(tenMH) ||
                string.IsNullOrWhiteSpace(ngayTao))
            {
                return new(false, false, "Dữ liệu nhập vào bị trống");
            }
            else if(soLuong <= 0)
            {
                return new(false, false, "Số lượng nhập vào không hợp lệ");
            }
            else if (ConvertDateString(ngayTao) == new DateTime())
            {
                return new(false, false, "Ngày Tạo Hóa Đơn không đúng định dạng");
            }

            DateTime date = ConvertDateString(ngayTao);
            if (NgayTaoHoaDonCoDiTruocThoiDiemTaoHoaDon(date))
            {
                return new(false, false, "Ngày Tạo Hóa Đơn vượt quá ngày hiện tại");
            }

            HoaDon editHD = new();
            editHD.MaHoaDon = maHD;
            editHD.TenMatHang = tenMH.ToUpper();
            editHD.NgayTao = ngayTao;
            editHD.SoLuong = soLuong;
            luuTruHoaDonNhap.SuaHoaDon(editHD);

            return new(true, true, string.Empty);
        }

        public ServiceResult<bool> TaoMoiHoaDon
            (string maHD, string tenMH, string ngayTao, int soLuong)
        {
            if(string.IsNullOrWhiteSpace(maHD) ||
                string.IsNullOrWhiteSpace(tenMH) ||
                string.IsNullOrWhiteSpace(ngayTao))
            {
                return new(false, false, "Dữ liệu nhập vào bị trống");
            }
            else if(soLuong <= 0)
            {
                return new(false, false, "Số lượng nhập vào không hợp lệ");
            }
            else if (KiemTraMaHoaDonDaCo(maHD.ToUpper()))
            {
                return new(false, false, "Mã Hóa Đơn đã tồn tại");
            }
            else if(ConvertDateString(ngayTao) == new DateTime())
            {
                return new(false, false, "Ngày Tạo Hóa Đơn không đúng định dạng");
            }

            DateTime date = ConvertDateString(ngayTao);
            if (NgayTaoHoaDonCoDiTruocThoiDiemTaoHoaDon(date))
            {
                return new(false, false, "Ngày Tạo Hóa Đơn không hợp lệ");
            }

            HoaDon newHD = new(maHD.ToUpper(), tenMH.ToUpper(), ngayTao, soLuong);
            luuTruHoaDonNhap.TaoMoiHD(newHD);

            return new(true, true, string.Empty);
        }

        public List<HoaDon> TimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                tuKhoa = string.Empty;
            }
            List<HoaDon> dsHD = luuTruHoaDonNhap.DocDanhSachHoaDon();
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
            luuTruHoaDonNhap.XoaHoaDon(maHD);
        }

        public bool KiemTraMaHoaDonDaCo(string maHD)
        {
            List<HoaDon> dsHDNhap = luuTruHoaDonNhap.DocDanhSachHoaDon();
            foreach(HoaDon item in dsHDNhap)
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
                date = DateTime.ParseExact(dateString, "d/M/yyyy", culture);
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

        public int CapNhatSoLuongHangTonKho(string tenMH, DateTime ngayCapNhat)
        {
            int soLuongTonKho = 0;
            List<HoaDon> dsHDNhap = luuTruHoaDonNhap.DocDanhSachHoaDon();
            foreach (HoaDon item in dsHDNhap)
            {
                DateTime ngayTao = ConvertDateString(item.NgayTao);
                int checkDate = DateTime.Compare(ngayTao, ngayCapNhat);
                if(item.TenMatHang == tenMH && checkDate < 0)
                {
                    soLuongTonKho += item.SoLuong;
                }
            }

            return soLuongTonKho;
        }
    }
}
