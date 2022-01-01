using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_SMS;

namespace GUI_SMS
{
    public partial class GUI_TimKiem : Form
    {
        BUS_TimKiem busTimKiem = new BUS_TimKiem();
        BUS_DienThoai busDienThoai = new BUS_DienThoai();
        public GUI_TimKiem()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (radmasp.Checked)
            {
                dgvTimkiem.DataSource = busTimKiem.TimMasp(txtMasp.Text.Trim().ToLower());
            }
            if (radtensp.Checked)
            {
                dgvTimkiem.DataSource = busTimKiem.TimTensp(txtTensp.Text.Trim().ToLower());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            GUI_BanDienThoai f = new GUI_BanDienThoai();
            f.Show();
        }
    }
}
