using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace QuanLyCuaHang.Pages.MH_LoaiHang
{
    public class DanhSachLHModel : PageModel
    {
        private IXuLyLoaiHang xuLyLoaiHang;
        public string Chuoi = string.Empty;
        public List<LoaiHang> dsLH;

        [BindProperty]
        public string TuKhoa { get; set; }

        public DanhSachLHModel()
        {
            xuLyLoaiHang = new XuLyLoaiHang();
            dsLH = new List<LoaiHang>();
        }
        public void OnGet()
        {
            dsLH = xuLyLoaiHang.TimKiemLH(string.Empty);
        }

        public void OnPost()
        {
            dsLH = xuLyLoaiHang.TimKiemLH(TuKhoa);
        }
    }
}
