using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_DienThoai:DBConnection
    {
        public DataTable getDienThoai()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SanPham ", con);
            DataTable daDienThoai = new DataTable();
            da.Fill(daDienThoai);
            daDienThoai.Columns.Add("Ord");
            for (int i = 1; i <= daDienThoai.Rows.Count; i++)
                daDienThoai.Rows[i - 1]["Ord"] = i.ToString();
            return daDienThoai;
        }

        public bool insertDienThoai(string masp, string tensp, string sl, string gia)
        {
            string str = string.Format("insert into SanPham(Masp, Tensp, Soluong, Gia) values('{0}', '{1}', '{2}', '{3}')", masp, tensp, sl, gia);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }

        public bool updateDienThoai(string masp, string masp1, string tensp, string sl, string gia)
        {
            string str = string.Format("update SanPham set Masp='{0}', Tensp='{1}', Soluong='{2}', Gia='{3}' where Masp='{4}'", masp1, tensp, sl, gia, masp);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }

        public bool deleteDienThoai(string masp)
        {
            string str = string.Format("delete from SanPham where masp='{0}'", masp);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
    }
}
