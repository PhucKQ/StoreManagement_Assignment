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
    public class TaoMoiHoaDonNhapModel : PageModel
    {
        public string Chuoi = string.Empty;
        private IXuLyHoaDon xuLyHoaDon;
        private IXuLyMatHang xuLyMatHang;
        public List<MatHang> dsMH;

        [BindProperty]
        public string MaHD { get; set; }
        [BindProperty]
        public string TenMH { get; set; }
        [BindProperty]
        public string NgayTao { get; set; }
        [BindProperty]
        public int SoLuong { get; set; }
        public TaoMoiHoaDonNhapModel()
        {
            xuLyHoaDon = new XuLyHoaDonNhap();
            xuLyMatHang = new XuLyMatHang();
            dsMH = xuLyMatHang.TimKiemMH(string.Empty);
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            ServiceResult<bool> kq = xuLyHoaDon.TaoMoiHoaDon(MaHD, TenMH, NgayTao, SoLuong);
            if (kq.IsSuccess)
            {
                Response.Redirect("./DanhSachHoaDonNhap");
            }
            else
            {
                Chuoi = kq.ErrorMessage;
            }
        }
    }
}
