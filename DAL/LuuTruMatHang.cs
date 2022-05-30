using System;
using System.IO;
using Newtonsoft.Json;
using Entities;
using System.Collections.Generic;

namespace DAL
{
    public class LuuTruMatHang : ILuuTruMatHang
    {
        public string filePath = "../DAL/MatHang.json";
        public List<MatHang> DocDanhSachMatHang()
        {
            StreamReader reader = new(filePath);
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<MatHang> dsLH = JsonConvert.DeserializeObject
                <List<MatHang>>(jsonString);

            return dsLH;
        }

        public void LuuDanhSachMatHang(List<MatHang> dsLH)
        {
            StreamWriter writer = new(filePath);
            string jsonString = JsonConvert.SerializeObject(dsLH);
            writer.Write(jsonString);
            writer.Close();
        }

        public void TaoMoiMatHang(MatHang newMH)
        {
            List<MatHang> dsLH = DocDanhSachMatHang();
            dsLH.Add(newMH);
            LuuDanhSachMatHang(dsLH);
        }

        public MatHang DocMatHang(string maLH)
        {
            List<MatHang> dsLH = DocDanhSachMatHang();
            foreach(MatHang eachItem in dsLH)
            {
                if(eachItem.MaMatHang == maLH)
                {
                    return eachItem;
                }
            }

            return null;
        }

        public void SuaMatHang(MatHang editMH)
        {
            List<MatHang> dsMH = DocDanhSachMatHang();
            for(int i = 0; i < dsMH.Count; i++)
            {
                if(dsMH[i].MaMatHang == editMH.MaMatHang)
                {
                    dsMH[i] = editMH;
                    LuuDanhSachMatHang(dsMH);
                    break;
                }
            }
        }

        public void XoaMatHang(string maLH)
        {
            List<MatHang> dsMH = DocDanhSachMatHang();
            foreach (MatHang item in dsMH)
            {
                if (item.MaMatHang == maLH)
                {
                    dsMH.Remove(item);
                    LuuDanhSachMatHang(dsMH);
                    break;
                }
            }
        }

    }
}
