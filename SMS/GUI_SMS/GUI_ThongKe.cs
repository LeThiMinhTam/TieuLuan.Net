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
    public partial class GUI_ThongKe : Form
    {
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = busThongKe.getThongKe();
        }
    }
}
