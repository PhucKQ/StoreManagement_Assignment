using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface ILuuTruMatHang
    {
        List<MatHang> DocDanhSachMatHang();
        void LuuDanhSachMatHang(List<MatHang> dsMH);
        void TaoMoiMatHang(MatHang newMH);
        void SuaMatHang(MatHang editMH);
        void XoaMatHang(string maMH);
        MatHang DocMatHang(string maMH);

    }
}
