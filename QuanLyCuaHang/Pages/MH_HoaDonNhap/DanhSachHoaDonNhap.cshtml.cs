using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_HoaDonNhap
{
    public class DanhSachHoaDonNhapModel : PageModel
    {
        private IXuLyHoaDon xuLyHoaDon;
        public string Chuoi = string.Empty;
        public List<HoaDon> dsHD;

        [BindProperty]
        public string TuKhoa { get; set; }

        public DanhSachHoaDonNhapModel()
        {
            xuLyHoaDon = new XuLyHoaDonNhap();
            dsHD = new List<HoaDon>();
        }
        public void OnGet()
        {
            dsHD = xuLyHoaDon.TimKiem(string.Empty);
        }

        public void OnPost()
        {
            dsHD = xuLyHoaDon.TimKiem(TuKhoa);
        }
    }
}
