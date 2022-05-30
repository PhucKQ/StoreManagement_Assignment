using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_MatHang
{
    public class DanhSachMHModel : PageModel
    {
        private IXuLyMatHang xuLyMatHang;
        private IXuLyLoaiHang xuLyLoaiHang;
        public string Chuoi = string.Empty;
        public List<MatHang> dsMH;
        public List<LoaiHang> dsLH;

        [BindProperty]
        public string TuKhoa { get; set; }

        public DanhSachMHModel()
        {
            xuLyMatHang = new XuLyMatHang();
            xuLyLoaiHang = new XuLyLoaiHang(); 
            dsMH = new();
            dsLH = xuLyLoaiHang.TimKiemLH(string.Empty);
        }

        public void OnGet()
        {
            dsMH = xuLyMatHang.TimKiemMH(string.Empty);

        }

        public void OnPost()
        {
            dsMH = xuLyMatHang.TimKiemMH(TuKhoa);
        }
    }
}
