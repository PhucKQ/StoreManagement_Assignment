using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_HoaDonXuat
{
    public class TaoMoiHoaDonBanModel : PageModel
    {
        public string Chuoi = string.Empty;
        private IXuLyHoaDon xuLyHDBanHang;
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
        public TaoMoiHoaDonBanModel()
        {
            xuLyHDBanHang = new XuLyHoaDonBan();
            xuLyMatHang = new XuLyMatHang();
            dsMH = xuLyMatHang.TimKiemMH(string.Empty);
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            ServiceResult<bool> kq = xuLyHDBanHang.TaoMoiHoaDon(MaHD, TenMH, NgayTao, SoLuong);
            if (kq.IsSuccess)
            {
                Response.Redirect("./DanhSachHoaDonBan");
            }
            else
            {
                Chuoi = kq.ErrorMessage;
            }
        }
    }
}
