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
    public class XoaLHModel : PageModel
    {
        private IXuLyLoaiHang xuLyLoaiHang;
        private IXuLyMatHang xuLyMatHang;
        public string Chuoi = string.Empty;
        public LoaiHang truyXuatLH;
        public List<LoaiHang> dsLH;
        public bool coSanPham;
        public List<MatHang> dsMHLienQuan;

        [BindProperty(SupportsGet = true)]
        public string MaLH { get; set; }
        [BindProperty]
        public string TenLH { get; set; }

        public XoaLHModel()
        {
            xuLyLoaiHang = new XuLyLoaiHang();
            xuLyMatHang = new XuLyMatHang();
            truyXuatLH = new();
            dsLH = xuLyLoaiHang.TimKiemLH(string.Empty);
            dsMHLienQuan = new();
        }
        public void OnGet()
        {
            truyXuatLH = xuLyLoaiHang.DocMaLoaiHang(MaLH);
            List<MatHang> dsMH = xuLyMatHang.TimKiemMH(string.Empty);
            if (truyXuatLH != null)
            {
                coSanPham = true;
                foreach(MatHang item in dsMH)
                {
                    if(item.MaLoaiHang == truyXuatLH.MaLoaiHang)
                    {
                        dsMHLienQuan.Add(item);
                    }
                }
            }
            else
            {
                coSanPham = false;
                Chuoi = "Không tìm thấy sản phẩm";
            }
        }

        public void OnPost()
        {
            var kq = xuLyLoaiHang.XoaLH(MaLH);
            if (kq)
            {
                Response.Redirect("/MH_LoaiHang/DanhSachLH");
            }
            else
            {
                Chuoi = "Không thể xóa";
            }
        }
    }
}
