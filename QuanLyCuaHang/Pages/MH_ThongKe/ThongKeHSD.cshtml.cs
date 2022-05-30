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
    public class ThongKeHSDModel : PageModel
    {
        private IXuLyMatHang xuLyMatHang;
        public List<MatHang> dsMH;
        public bool[] daHetHanSuDung;
        DateTime toDay = DateTime.Today;

        public ThongKeHSDModel()
        {
            xuLyMatHang = new XuLyMatHang();
        }

        public void OnGet()
        {
            dsMH = xuLyMatHang.TimKiemMH(string.Empty);
            daHetHanSuDung = new bool[dsMH.Count];
            for (int i = 0; i < dsMH.Count; i++)
            {
                xuLyMatHang.ConvertDateStringToDateTime(dsMH[i].HanSuDung, out DateTime hsd);
                int checkDate = DateTime.Compare(hsd, toDay);
                if (checkDate <= 0)
                {
                    daHetHanSuDung[i] = true;
                }
                else 
                { 
                    daHetHanSuDung[i] = false; 
                }
            }
        }
    }
}
