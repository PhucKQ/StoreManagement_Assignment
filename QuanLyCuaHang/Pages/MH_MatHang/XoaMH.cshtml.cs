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
    public class XoaMHModel : PageModel
    {
        private IXuLyMatHang xuLyMatHang;
        private IXuLyLoaiHang xuLyLoaiHang;
        public string Chuoi = string.Empty;
        public List<LoaiHang> dsLH;
        public MatHang matHang;
        public bool coSanPham;

        [BindProperty(SupportsGet = true)]
        public string MaMH { get; set; }

        public XoaMHModel()
        {
            xuLyMatHang = new XuLyMatHang();
            xuLyLoaiHang = new XuLyLoaiHang();
            dsLH = xuLyLoaiHang.TimKiemLH(string.Empty);
            matHang = new();
        }

        public void OnGet()
        {
            matHang = xuLyMatHang.DocMaMatHang(MaMH);
            if (matHang != null)
            {
                coSanPham = true;
            }
            else
            {
                coSanPham = false;
                Chuoi = "Khong tim thay san pham";
            }
        }

        public void OnPost()
        {
            var kq = xuLyMatHang.XoaMH(MaMH);
            if (kq)
            {
                Response.Redirect("/MH_MatHang/DanhSachMH");
            }
            else
            {
                Chuoi = "Khong the xoa";
            }
        }
    }
}
