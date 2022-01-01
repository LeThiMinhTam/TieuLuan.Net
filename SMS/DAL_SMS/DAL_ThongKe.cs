using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_ThongKe:DBConnection
    {
        public DataTable getThongKe()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon", con);
            DataTable daThongKe = new DataTable();
            da.Fill(daThongKe);
            return daThongKe;
        }
    }
}
