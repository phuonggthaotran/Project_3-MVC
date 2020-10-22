using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DoAn3.Models.Objects
{
    public class DataConnection
    {
        
            protected SqlConnection cn;
            protected SqlCommand cmd;
            protected SqlDataAdapter da;
            protected DataTable dt;

            public DataConnection()
            {
                // tạo 1 kết nối bằng các thông tin ở trên
                cn = new SqlConnection(@"Data Source=DESKTOP-7R75IKF;Initial Catalog=TuLanShopDB;Integrated Security=True; UserID = sa;Password = 1");
            }

            // hàm lấy dữ liệu từ các lệnh sql như: select
            public DataTable GetData(string query)
            {
                cn.Open();
                da = new SqlDataAdapter(query, cn);
                dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }

            // hàm lưu dữ liệu từ các lệnh sql như: insert, update, delete
            public void SaveData(string query)
            {
                cn.Open();
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cn.Close();
            }
        }
    }
