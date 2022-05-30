using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LuuTruHoaDonBan : ILuuTruHoaDon
    {
        public string filePath = ("../DAL/HoaDonBan.json");

        public List<HoaDon> DocDanhSachHoaDon()
        {
            StreamReader reader = new(filePath);
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<HoaDon> dsHD= JsonConvert.DeserializeObject
                <List<HoaDon>>(jsonString);

            return dsHD;
        }

        public HoaDon DocMaHoaDon(string maHD)
        {
            List<HoaDon> dsHD = DocDanhSachHoaDon();
            foreach (HoaDon eachItem in dsHD)
            {
                if (eachItem.MaHoaDon == maHD)
                {
                    return eachItem;
                }
            }

            return null;
        }

        public void LuuDanhSachHoaDon(List<HoaDon> dsHD)
        {
            StreamWriter writer = new(filePath);
            string jsonString = JsonConvert.SerializeObject(dsHD);
            writer.Write(jsonString);
            writer.Close();
        }

        public void SuaHoaDon(HoaDon editHD)
        {
            List<HoaDon> dsHD = DocDanhSachHoaDon();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if(dsHD[i].MaHoaDon == editHD.MaHoaDon)
                {
                    dsHD[i] = editHD;
                    LuuDanhSachHoaDon(dsHD);
                }
            }
        }

        public void TaoMoiHD(HoaDon newHD)
        {
            List<HoaDon> dsHD = DocDanhSachHoaDon();
            dsHD.Add(newHD);
            LuuDanhSachHoaDon(dsHD);
        }

        public void XoaHoaDon(string maHD)
        {
            List<HoaDon> dsHD = DocDanhSachHoaDon();
            foreach(HoaDon eachItem in dsHD)
            {
                if(eachItem.MaHoaDon == maHD)
                {
                    dsHD.Remove(eachItem);
                    LuuDanhSachHoaDon(dsHD);
                    break;
                }
            }
        }
    }
}
