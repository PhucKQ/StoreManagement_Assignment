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
    public class SuaMHModel : PageModel
    {
        private IXuLyMatHang xuLyMatHang;
        private IXuLyLoaiHang xuLyLoaiHang;
        public string Chuoi = string.Empty;
        public MatHang thongTinMH;
        public bool coSanPham;
        public List<LoaiHang> dsLH;
        public string TenLH;


        [BindProperty(SupportsGet = true)]
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

        public SuaMHModel()
        {
            xuLyMatHang = new XuLyMatHang();
            xuLyLoaiHang = new XuLyLoaiHang();
            thongTinMH = new();
            dsLH = xuLyLoaiHang.TimKiemLH(string.Empty);
        }

        public void OnGet()
        {
            MatHang truyXuatMH = xuLyMatHang.DocMaMatHang(MaMH);
            if(truyXuatMH != null)
            {
                coSanPham = true;
                thongTinMH = truyXuatMH;
                // tạo dropdown list
                foreach (LoaiHang eachLH in dsLH)
                {
                    if (eachLH.MaLoaiHang == thongTinMH.MaLoaiHang)
                    {
                        TenLH = eachLH.TenLoaiHang;
                        dsLH.Remove(eachLH);
                        break;
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
            var kq = xuLyMatHang.SuaMH(MaMH, TenMH, Cty, HSD, NSX, LH);
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
