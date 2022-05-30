using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_ThongKe
{
    public class ThongKeKhoModel : PageModel
    {
        private IXuLyMatHang xuLyMatHang;
        private IXuLyHoaDon xuLyHoaDonNhap, xuLyHoaDonBan;
        public List<MatHang> dsMH;
        public int[] SoLuongTonKho;
        DateTime toDay = DateTime.Today;

        public ThongKeKhoModel()
        {
            xuLyMatHang = new XuLyMatHang();
            xuLyHoaDonNhap = new XuLyHoaDonNhap();
            xuLyHoaDonBan = new XuLyHoaDonBan();
        }

        public void OnGet()
        {
            dsMH = xuLyMatHang.TimKiemMH(string.Empty);
            SoLuongTonKho = new int[dsMH.Count];
            for (int i = 0; i < dsMH.Count; i++)
            {
                int tongSoLuongNhap = xuLyHoaDonNhap.CapNhatSoLuongHangTonKho(dsMH[i].TenMatHang, toDay);
                int tongSoLuongBan = xuLyHoaDonBan.CapNhatSoLuongHangTonKho(dsMH[i].TenMatHang, toDay);
                SoLuongTonKho[i] = tongSoLuongNhap - tongSoLuongBan;
            }
            
        }

    }
}
