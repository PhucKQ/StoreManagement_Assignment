using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IXuLyMatHang
    {
        List<MatHang> TimKiemMH(string tuKhoa);
        ServiceResult<bool> TaoMoiMH
            (string maMH, string tenMH, string cty, string hanSuDung, string ngaySanXuat, string loaiHang);
        bool KiemTraMaDaCo(string maMH);
        bool KiemTraTenDaCo(string maMH, string tenMH);
        ServiceResult<bool> SuaMH
            (string maMH, string tenMH, string cty, string hanSuDung, string ngaySanXuat, string loaiHang);
        bool XoaMH(string maLH);
        MatHang DocMaMatHang(string maMH);
        bool ConvertDateStringToDateTime(string dateString, out DateTime date);
    }
}
