using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_HoaDonBan
{
    public class XoaHoaDonBanModel : PageModel
    {
        private IXuLyHoaDon xuLyHDBanHang;
        public string Chuoi = string.Empty;
        public bool coDuLieu;
        public HoaDon thongTinHD;

        [BindProperty(SupportsGet = true)]
        public string MaHD { get; set; }

        public XoaHoaDonBanModel()
        {
            xuLyHDBanHang = new XuLyHoaDonBan();
            thongTinHD = new();
        }
        public void OnGet()
        {
            HoaDon truyXuatHD = xuLyHDBanHang.DocMaHoaDon(MaHD);
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
            xuLyHDBanHang.XoaHoaDon(MaHD);
            Response.Redirect("./DanhSachHoaDonBan");
        }
    }
}
