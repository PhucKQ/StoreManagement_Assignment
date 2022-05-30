using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface ILuuTruLoaiHang
    {
        List<LoaiHang> DocDanhSachLoaiHang();
        void LuuDanhSachLoaiHang(List<LoaiHang> dsLH);
        void TaoMoiLoaiHang(LoaiHang newLH);
        bool SuaLoaiHang(string maLH, string tenLH);
        void XoaLoaiHang(string maLH);
        LoaiHang DocLoaiHang(string maLH);
    }
}
