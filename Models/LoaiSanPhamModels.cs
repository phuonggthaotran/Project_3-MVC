using DoAn3.Models.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DoAn3.Models
{
    public class LoaiSanPhamModels
    {
        public List<LoaiSanPham> getAll()
        {
            string query = "SELECT * FROM brands";
            DataTable dt = GetData(query);
            return ToList(dt);
        }

        private DataTable GetData(string query)
        {
            throw new NotImplementedException();
        }

        public List<LoaiSanPham> ToList(DataTable dt)
        {
            List<LoaiSanPham> list = new List<LoaiSanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                LoaiSanPham obj = new LoaiSanPham();
                obj.id = int.Parse(dr[0].ToString());
                obj.name = dr[1].ToString();
                obj.image = dr[2].ToString();
                list.Add(obj);
            }

            return list;
        }
    }

}
