using System;
using System.IO;
using Newtonsoft.Json;
using Entities;
using System.Collections.Generic;

namespace DAL
{
    public class LuuTruLoaiHang : ILuuTruLoaiHang
    {
        public string filePath = "../DAL/LoaiHang.json";
        private ILuuTruMatHang luuTruMatHang = new LuuTruMatHang();

        public List<LoaiHang> DocDanhSachLoaiHang()
        {
            StreamReader reader = new(filePath);
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<LoaiHang> dsLH = JsonConvert.DeserializeObject
                <List<LoaiHang>>(jsonString);

            return dsLH;
        }

        public void LuuDanhSachLoaiHang(List<LoaiHang> dsLH)
        {
            StreamWriter writer = new(filePath);
            string jsonString = JsonConvert.SerializeObject(dsLH);
            writer.Write(jsonString);
            writer.Close();
        }

        public void TaoMoiLoaiHang(LoaiHang newLH)
        {
            List<LoaiHang> dsLH = DocDanhSachLoaiHang();
            dsLH.Add(newLH);
            LuuDanhSachLoaiHang(dsLH);
        }

        public LoaiHang DocLoaiHang(string maLH)
        {
            List<LoaiHang> dsLH = DocDanhSachLoaiHang();
            foreach(LoaiHang eachItem in dsLH)
            {
                if(eachItem.MaLoaiHang == maLH)
                {
                    return eachItem;
                }
            }

            return null;
        }

        public bool SuaLoaiHang(string maLH, string tenLH)
        {
            List<LoaiHang> dsLH = DocDanhSachLoaiHang();
            foreach(LoaiHang eachItem in dsLH)
            {
                if(eachItem.MaLoaiHang == maLH)
                {
                    eachItem.MaLoaiHang = maLH;
                    eachItem.TenLoaiHang = tenLH;
                    LuuDanhSachLoaiHang(dsLH);
                    return true;
                }
            }

            return false;
        }

        public void XoaLoaiHang(string maLH)
        {
            List<LoaiHang> dsLH = DocDanhSachLoaiHang();
            List <MatHang> dsMH = luuTruMatHang.DocDanhSachMatHang();
            foreach (LoaiHang eachItem in dsLH)
            {
                if (eachItem.MaLoaiHang == maLH)
                {
                    for (int i = 0; i < dsMH.Count; i++)
                    {
                        if(dsMH[i].MaLoaiHang == eachItem.TenLoaiHang)
                        {
                            dsMH.RemoveAt(i);
                        }
                    }
                    luuTruMatHang.LuuDanhSachMatHang(dsMH);
                    dsLH.Remove(eachItem);
                    LuuDanhSachLoaiHang(dsLH);
                    break;
                }
            }
        }
    }
}
