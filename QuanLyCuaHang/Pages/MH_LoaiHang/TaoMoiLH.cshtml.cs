using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_LoaiHang
{
    public class TaoMoiLHModel : PageModel
    {
        private IXuLyLoaiHang xuLyLoaiHang;
        public string Chuoi = string.Empty;

        [BindProperty]
        public string MaLH { get; set; }
        [BindProperty]
        public string TenLH { get; set; }

        public TaoMoiLHModel()
        {
            xuLyLoaiHang = new XuLyLoaiHang();
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var kq = xuLyLoaiHang.TaoMoiLH(MaLH, TenLH);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_LoaiHang/DanhSachLH");
            }
            else
            {
                Chuoi = kq.ErrorMessage;
            }
        }
    }
}
