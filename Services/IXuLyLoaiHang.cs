using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IXuLyLoaiHang
    {
        List<LoaiHang> TimKiemLH(string tuKhoa);
        ServiceResult<bool> TaoMoiLH(string maLH, string tenLH);
        bool KiemTraMaDaCo_LoaiHang(string maLH);
        bool KiemTraTenDaCo_LoaiHang(string maLH, string tenLH);
        ServiceResult<bool> SuaLH(string maLH, string tenLH);
        bool XoaLH(string maLH);
        LoaiHang DocMaLoaiHang(string maLH);
        
    }
}
