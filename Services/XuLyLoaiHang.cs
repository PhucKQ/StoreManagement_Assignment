using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace Services
{
    public class XuLyLoaiHang : IXuLyLoaiHang
    {
        private ILuuTruLoaiHang luuTruLoaiHang;
        //private ILuuTruMatHang luuTruMatHang;

        public XuLyLoaiHang()
        {
            luuTruLoaiHang = new LuuTruLoaiHang();
            //luuTruMatHang = new LuuTruMatHang();
        }

        public List<LoaiHang> TimKiemLH(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                tuKhoa = string.Empty;
            }
            List<LoaiHang> dsLH = luuTruLoaiHang.DocDanhSachLoaiHang();
            List <LoaiHang> dsKQ = new();
            for(int i = 0; i < dsLH.Count; i++)
            {
                if (dsLH[i].TenLoaiHang.Contains(tuKhoa) ||
                    dsLH[i].TenLoaiHang.Contains(tuKhoa.ToUpper()))
                {
                    dsKQ.Add(dsLH[i]);
                }
            }

            return dsKQ;
        }

        public ServiceResult<bool> TaoMoiLH(string maLH, string tenLH)
        {
            if (string.IsNullOrWhiteSpace(tenLH) ||
                string.IsNullOrWhiteSpace(maLH))
            {
                return new(false, false, "Dữ liệu nhập vào không thể để trống");
            }
            else if (KiemTraTenDaCo_LoaiHang(maLH, tenLH) ||
                     KiemTraMaDaCo_LoaiHang(maLH))
            {
                return new(false, false, "Trùng Mã Loại hàng hoặc Tên Loại hàng");
            }

            LoaiHang newLH = new LoaiHang();
            newLH.MaLoaiHang = maLH.ToUpper();
            newLH.TenLoaiHang = tenLH.ToUpper();
            luuTruLoaiHang.TaoMoiLoaiHang(newLH);

            return new(true, true,string.Empty);
        }

        public bool KiemTraMaDaCo_LoaiHang(string maLH)
        {
            List<LoaiHang> dsLH = luuTruLoaiHang.DocDanhSachLoaiHang();
            foreach (LoaiHang eachItem in dsLH)
            {
                if (eachItem.MaLoaiHang == maLH.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public bool KiemTraTenDaCo_LoaiHang(string maLH, string tenLH)
        {
            List<LoaiHang> dsLH = luuTruLoaiHang.DocDanhSachLoaiHang();
            foreach(LoaiHang eachItem in dsLH)
            {
                if(eachItem.TenLoaiHang == tenLH.ToUpper() && eachItem.MaLoaiHang != maLH.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public LoaiHang DocMaLoaiHang(string maLH)
        {
            var result = luuTruLoaiHang.DocLoaiHang(maLH);
            if(result != null)
            {
                return result;
            }

            return null;
        }

        public ServiceResult<bool> SuaLH(string maLH, string tenLH)
        {
            if (string.IsNullOrWhiteSpace(tenLH))
            {
                return new(false, false, "Dữ liệu nhập vào không thể để trống");
            }
            else if (KiemTraTenDaCo_LoaiHang(maLH, tenLH))
            {
                return new(false, false, "Trùng Tên Loại hàng");
            }

            luuTruLoaiHang.SuaLoaiHang(maLH, tenLH.ToUpper());

            return new(true, true, string.Empty);
        }

        public bool XoaLH(string maLH)
        {
            luuTruLoaiHang.XoaLoaiHang(maLH);
            return true;
        }
    }
}
