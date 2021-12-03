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
    public class BUS_DN
    {
        DAL_DN daDN = new DAL_DN();
        public int getDN(string username, string password)
        {
            return daDN.getDN(username, password);
        }

        
    }
}
