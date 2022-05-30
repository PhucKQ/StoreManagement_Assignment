using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ILuuTruHoaDon
    {
        List<HoaDon> DocDanhSachHoaDon();
        void LuuDanhSachHoaDon(List<HoaDon> dsHD);
        void TaoMoiHD(HoaDon newHD);
        HoaDon DocMaHoaDon(string maHD);
        void SuaHoaDon(HoaDon editHD);
        void XoaHoaDon(string maHD);
    }
}
