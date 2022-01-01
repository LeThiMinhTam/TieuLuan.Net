using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_TimKiem:DBConnection
    {
        public DataTable TimMasp(string masp)
        {
            string str = string.Format("select * from SanPham where lower(Masp) like '%{0}%'", masp.ToLower());
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable daTimKiem = new DataTable();
            da.Fill(daTimKiem);
            return daTimKiem;
        }

        public DataTable TimTensp(string tensp)
        {
            string str = string.Format("select * from SanPham where lower(Tensp) like '%{0}%'", tensp.ToLower());
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable daTimKiem = new DataTable();
            da.Fill(daTimKiem);
            return daTimKiem;
        }
    }
}
