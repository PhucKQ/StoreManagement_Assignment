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
    public class SuaHoaDonBanModel : PageModel
    {
        private IXuLyHoaDon xuLyHDBanHang;
        private IXuLyMatHang xuLyMatHang;
        public string Chuoi = string.Empty;
        public bool coDuLieu;
        public HoaDon thongTinHD;
        public List<string> dsTenMH;

        [BindProperty(SupportsGet = true)]
        public string MaHD { get; set; }
        [BindProperty]
        public string TenMH { get; set; }
        [BindProperty]
        public string NgayTao { get; set; }
        [BindProperty]
        public int SoLuong { get; set; }

        public SuaHoaDonBanModel()
        {
            xuLyHDBanHang = new XuLyHoaDonBan();
            xuLyMatHang = new XuLyMatHang();
            thongTinHD = new();
            dsTenMH = new();
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

            if (thongTinHD != null)
            {
                List<MatHang> dsMH = xuLyMatHang.TimKiemMH(string.Empty);
                foreach (MatHang item in dsMH)
                {
                    if (item.TenMatHang != thongTinHD.TenMatHang)
                    {
                        dsTenMH.Add(item.TenMatHang);
                    }
                }
            }

        }

        public void OnPost()
        {
            ServiceResult<bool> kq = xuLyHDBanHang.SuaHoaDon(MaHD, TenMH, NgayTao, SoLuong);
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
