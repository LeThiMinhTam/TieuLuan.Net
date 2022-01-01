using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_BanDienThoai:DBConnection
    {
        public DataTable getHD()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon ", con);
            DataTable daDienThoai = new DataTable();
            da.Fill(daDienThoai);
            
            return daDienThoai;
        }
        public bool insertHD(string mahd, string makh, string tenkh, string sdt, string masp, string sl)
        {
            string str = string.Format("insert into HoaDon(MaHD, MaKH, TenKH, SDT, Masp, sl) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", mahd, makh, tenkh, sdt, masp, sl);
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

        public bool updateSL(int soluong, string masp)
        {
            string str = string.Format("update SanPham set Soluong=Soluong-'{0}' where Masp='{1}'", soluong, masp,con );
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
