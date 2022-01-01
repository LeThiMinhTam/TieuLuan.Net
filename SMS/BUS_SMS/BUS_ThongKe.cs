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
    public class BUS_ThongKe
    {
        DAL_ThongKe daThongKe = new DAL_ThongKe();
        public DataTable getThongKe()
        {
            return daThongKe.getThongKe();
        }
    }
}
