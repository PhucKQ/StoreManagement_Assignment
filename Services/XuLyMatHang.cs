using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Services
{
    public class XuLyMatHang : IXuLyMatHang
    {
        private ILuuTruMatHang luuTruMatHang;
        public XuLyMatHang()
        {
            luuTruMatHang = new LuuTruMatHang();
        }

        public List<MatHang> TimKiemMH(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                tuKhoa = string.Empty;
            }
            List<MatHang> dsMH = luuTruMatHang.DocDanhSachMatHang();
            List<MatHang> dsKQ = new();
            for (int i = 0; i < dsMH.Count; i++)
            {
                if (dsMH[i].TenMatHang.Contains(tuKhoa) ||
                    dsMH[i].TenMatHang.Contains(tuKhoa.ToUpper()))
                {
                    dsKQ.Add(dsMH[i]);
                }
            }

            return dsKQ;
        }

        public ServiceResult<bool> TaoMoiMH
        (string maMH, string tenMH, string cty, string hanSuDung, string ngaySanXuat, string loaiHang)
        {
            DateTime hsd, nsx;

            if (string.IsNullOrWhiteSpace(maMH) || string.IsNullOrWhiteSpace(tenMH) ||
                string.IsNullOrWhiteSpace(cty) || string.IsNullOrWhiteSpace(hanSuDung) ||
                string.IsNullOrWhiteSpace(ngaySanXuat) || string.IsNullOrWhiteSpace(loaiHang))
            {
                return new(false, false, "Dữ liệu nhập vào không thể để trống");
            }
            else if (KiemTraTenDaCo(maMH, tenMH) ||
                     KiemTraMaDaCo(maMH))
            {
                return new(false, false, "Trùng Tên Mặt hàng hoặc Mã Mặt hàng");
            }
            else if (ConvertDateStringToDateTime(hanSuDung, out hsd) == false)
            {
                return new(false, false, "HSD nhập vào không đúng định dạng");
            }
            else if (ConvertDateStringToDateTime(ngaySanXuat, out nsx) == false)
            {
                return new(false, false, "NSX nhập vào không đúng định dạng");
            }

            int checkDate = DateTime.Compare(hsd, nsx);
            if (checkDate <= 0)
            {
                return new(false, false, "HSD & NSX nhập vào không hợp lệ");
            }

            MatHang newMH = new();
            newMH.MaMatHang = maMH.ToUpper();
            newMH.TenMatHang = tenMH.ToUpper();
            newMH.CtySanXuat = cty.ToUpper();
            newMH.HanSuDung = hanSuDung;
            newMH.NgaySanXuat = ngaySanXuat;
            newMH.MaLoaiHang = loaiHang;
            luuTruMatHang.TaoMoiMatHang(newMH);

            return new(true, true, string.Empty);
        }

        public bool KiemTraMaDaCo(string maMH)
        {
            List<MatHang> dsMH = luuTruMatHang.DocDanhSachMatHang();
            foreach (MatHang eachItem in dsMH)
            {
                if (eachItem.MaMatHang == maMH.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public bool KiemTraTenDaCo(string maMH, string tenMH)
        {
            List<MatHang> dsMH = luuTruMatHang.DocDanhSachMatHang();
            foreach (MatHang eachItem in dsMH)
            {
                if (eachItem.TenMatHang == tenMH.ToUpper() && eachItem.MaMatHang != maMH)
                {
                    return true;
                }
            }

            return false;
        }

        public MatHang DocMaMatHang(string maMH)
        {
            var result = luuTruMatHang.DocMatHang(maMH);
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public ServiceResult<bool> SuaMH
        (string maMH, string tenMH, string cty, string hanSuDung, string ngaySanXuat, string loaiHang)
        {
            DateTime hsd, nsx;

            if (string.IsNullOrWhiteSpace(tenMH) || string.IsNullOrWhiteSpace(cty) || 
                string.IsNullOrWhiteSpace(loaiHang))
            {
                return new(false, false, "Dữ liệu nhập vào không thể để trống");
            }
            else if (KiemTraTenDaCo(maMH, tenMH))
            {
                return new(false, false, "Trùng Tên Mặt hàng");
            }
            else if (ConvertDateStringToDateTime(hanSuDung, out hsd) == false)
            {
                return new(false, false, "HSD nhập vào không đúng định dạng");
            }
            else if (ConvertDateStringToDateTime(ngaySanXuat, out nsx) == false)
            {
                return new(false, false, "NSX nhập vào không đúng định dạng");
            }

            // kiểm tra HSD & NSX có hợp lệ
            int checkDate = DateTime.Compare(hsd, nsx);
            if (checkDate <= 0)
            {
                return new(false, false, "HSD & NSX nhập vào không hợp lệ");
            }

            MatHang editMH = new();
            editMH.MaMatHang = maMH;
            editMH.TenMatHang = tenMH.ToUpper();
            editMH.CtySanXuat = cty.ToUpper();
            editMH.HanSuDung = hanSuDung;
            editMH.NgaySanXuat = ngaySanXuat;
            editMH.MaLoaiHang = loaiHang;
            luuTruMatHang.SuaMatHang(editMH);

            return new(true, true, string.Empty);
        }

        public bool XoaMH(string maMH)
        {
            luuTruMatHang.XoaMatHang(maMH);

            return true;
        }

        public bool ConvertDateStringToDateTime(string dateString, out DateTime date)
        {
            // chuyển đổi ngày từ string -> DateTime
            CultureInfo culture = new("vi-VN");
            try
            {
                date = DateTime.ParseExact(dateString, "d/M/yyyy", culture);
            }
            catch (Exception)
            {
                date = new();
                return false;
            }

            return true;
        }


    }
}
