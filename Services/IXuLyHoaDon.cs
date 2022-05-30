using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IXuLyHoaDon
    {
        ServiceResult<bool> TaoMoiHoaDon(string maHD, string tenMH, string ngayTao, int soLuong);
        List<HoaDon> TimKiem(string tuKhoa);
        HoaDon DocMaHoaDon(string maHD);
        ServiceResult<bool> SuaHoaDon(string maHD, string tenMH, string ngayTao, int soLuong);
        void XoaHoaDon(string maHD);
        bool KiemTraMaHoaDonDaCo(string maHD);
        DateTime ConvertDateString(string dateString);
        bool NgayTaoHoaDonCoDiTruocThoiDiemTaoHoaDon(DateTime date);
        int CapNhatSoLuongHangTonKho(string tenMH, DateTime ngayCapNhat);
    }
}
