﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace QuanLyCuaHang.Pages.MH_HoaDonNhap
{
    public class SuaHoaDonNhapModel : PageModel
    {
        private IXuLyHoaDon xuLyHoaDon;
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

        public SuaHoaDonNhapModel()
        {
            xuLyHoaDon = new XuLyHoaDonNhap();
            xuLyMatHang = new XuLyMatHang();
            thongTinHD = new();
            dsTenMH = new();
        }

        public void OnGet()
        {
            HoaDon truyXuatHD = xuLyHoaDon.DocMaHoaDon(MaHD);
            if(truyXuatHD != null)
            {
                coDuLieu = true;
                thongTinHD = truyXuatHD;
            }
            else
            {
                coDuLieu = false;
                Chuoi = "Không tìm thấy dữ liệu";
            }
            
            if(thongTinHD != null)
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
            ServiceResult<bool> kq = xuLyHoaDon.SuaHoaDon(MaHD, TenMH, NgayTao, SoLuong);
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
