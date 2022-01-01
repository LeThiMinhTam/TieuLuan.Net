using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;
using System.Data;
using System.Data.SqlClient;

namespace BUS_SMS
{
    public class BUS_TimKiem
    {
        DAL_TimKiem daTimKiem = new DAL_TimKiem();
        public DataTable TimMasp(string masp)
        {
            return daTimKiem.TimMasp(masp);
        }

        public DataTable TimTensp(string tensp)
        {
            return daTimKiem.TimTensp(tensp);
        }
    }
}
