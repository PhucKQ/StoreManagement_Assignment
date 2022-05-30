using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_HoaDonXuat
{
    public class DanhSachHoaDonBanModel : PageModel
    {
        private IXuLyHoaDon xuLyHDBanHang;
        public string Chuoi = string.Empty;
        public List<HoaDon> dsHD;

        [BindProperty]
        public string TuKhoa { get; set; }

        public DanhSachHoaDonBanModel()
        {
            xuLyHDBanHang = new XuLyHoaDonBan();
            dsHD = new List<HoaDon>();
        }
        public void OnGet()
        {
            dsHD = xuLyHDBanHang.TimKiem(string.Empty);
        }

        public void OnPost()
        {
            dsHD = xuLyHDBanHang.TimKiem(TuKhoa);
        }
    }
}
