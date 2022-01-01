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
    public class BUS_DienThoai
    {
        DAL_DienThoai daDienThoai = new DAL_DienThoai();
        public DataTable getDienThoai()
        {
            return daDienThoai.getDienThoai();
        }
        public bool insertDienThoai(string masp, string tensp, string sl, string gia)
        {
            return daDienThoai.insertDienThoai(masp, tensp, sl, gia);
        }

        public bool updateDienThoai(string masp, string masp1, string tensp, string sl, string gia)
        {
            return daDienThoai.updateDienThoai(masp, masp1, tensp, sl, gia);
        }

        public bool deleteDienThoai(string masp)
        {
            return daDienThoai.deleteDienThoai(masp);
        }
    }
}
