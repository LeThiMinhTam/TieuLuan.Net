using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_DN : DBConnection
    {
        public int getDN(string username, string password)
        {
            
            SqlDataAdapter da = new SqlDataAdapter($"select * from TK where username='{username}' and password='{password}'", con);//thuc hien cau lenh sql
            DataTable daDN = new DataTable();
            da.Fill(daDN);
            if (daDN.Rows.Count >0)
            {
                return 1;
            }
            else return 0;
            
        }
    }
}
