using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_LoaiHang
{
    public class SuaLHModel : PageModel
    {
        private IXuLyLoaiHang xuLyLoaiHang;
        public LoaiHang loaiHang;
        public string Chuoi = string.Empty;
        public bool coSanPham;

        [BindProperty(SupportsGet = true)]
        public string MaLH { get; set; }
        [BindProperty]
        public string TenLH { get; set; }

        public SuaLHModel()
        {
            xuLyLoaiHang = new XuLyLoaiHang();
            loaiHang = new LoaiHang();
        }
        public void OnGet()
        {
            loaiHang = xuLyLoaiHang.DocMaLoaiHang(MaLH);
            if (loaiHang != null)
            {
                coSanPham = true;
            }
            else
            {
                coSanPham = false;
                Chuoi = "Không tìm thấy sản phẩm";
            }
        }

        public void OnPost()
        {
            var kq = xuLyLoaiHang.SuaLH(MaLH, TenLH);
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
