using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string TenMatHang { get; set; }
        public string NgayTao { get; set; }
        public int SoLuong { get; set; }

        public HoaDon()
        {
        }

        public HoaDon(string maHD, string tenMH, string ngayTao, int soLuong)
        {
            MaHoaDon = maHD;
            TenMatHang = tenMH;
            NgayTao = ngayTao;
            SoLuong = soLuong;
        }
    }
}
