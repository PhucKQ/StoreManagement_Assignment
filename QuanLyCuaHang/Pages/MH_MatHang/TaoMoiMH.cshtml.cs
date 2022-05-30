using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace QuanLyCuaHang.Pages.MH_MatHang
{
    public class TaoMoiMHModel : PageModel
    {
        private IXuLyMatHang xuLyMatHang;
        private IXuLyLoaiHang xuLyLoaiHang;
        public string Chuoi = string.Empty;
        public List<LoaiHang> dsLH;

        [BindProperty]
        public string MaMH { get; set; }
        [BindProperty]
        public string TenMH { get; set; }
        [BindProperty]
        public string Cty { get; set; }
        [BindProperty]
        public string HSD { get; set; }
        [BindProperty]
        public string NSX { get; set; }
        [BindProperty]
        public string LH { get; set; }

        public TaoMoiMHModel()
        {
            xuLyMatHang = new XuLyMatHang();
            xuLyLoaiHang = new XuLyLoaiHang();
            dsLH = xuLyLoaiHang.TimKiemLH(string.Empty);
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            var kq = xuLyMatHang.TaoMoiMH(MaMH, TenMH, Cty, HSD, NSX, LH);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_MatHang/DanhSachMH");
            }
            else
            {
                    Chuoi = kq.ErrorMessage;
            }
        }
    }
}
