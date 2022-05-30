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
    public class XoaHoaDonNhapModel : PageModel
    {
        private IXuLyHoaDon xuLyHoaDon;
        public string Chuoi = string.Empty;
        public bool coDuLieu;
        public HoaDon thongTinHD;

        [BindProperty(SupportsGet = true)]
        public string MaHD { get; set; }

        public XoaHoaDonNhapModel()
        {
            xuLyHoaDon = new XuLyHoaDonNhap();
            thongTinHD = new();
        }
        public void OnGet()
        {
            HoaDon truyXuatHD = xuLyHoaDon.DocMaHoaDon(MaHD);
            if (truyXuatHD != null)
            {
                coDuLieu = true;
                thongTinHD = truyXuatHD;
            }
            else
            {
                coDuLieu = false;
                Chuoi = "Không tìm thấy dữ liệu";
            }
        }

        public void OnPost()
        {
            xuLyHoaDon.XoaHoaDon(MaHD);
            Response.Redirect("./DanhSachHoaDonNhap");
        }
    }
}
