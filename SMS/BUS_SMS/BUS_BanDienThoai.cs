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
    public class BUS_BanDienThoai
    {
        DAL_BanDienThoai daBanDienThoai = new DAL_BanDienThoai();
        public DataTable getHD()
        {
            return daBanDienThoai.getHD();
        }
        public bool insertHD(string mahd, string makh, string tenkh, string sdt, string masp, string sl)
        {
            return daBanDienThoai.insertHD(mahd, makh, tenkh, sdt, masp, sl);
        }
        public bool updateSL(int soluong, string masp)
        {
            return daBanDienThoai.updateSL(soluong, masp);
        }
    }
}
