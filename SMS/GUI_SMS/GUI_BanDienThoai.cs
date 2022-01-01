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
    public partial class GUI_BanDienThoai : Form
    {
        BUS_BanDienThoai busBanDienThoai = new BUS_BanDienThoai();
        BUS_DienThoai busDienThoai = new BUS_DienThoai();

        GUI_DienThoai g = new GUI_DienThoai();
        public GUI_BanDienThoai()
        {
            InitializeComponent();
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text!="" && txtMaKH.Text!="" && txtTenKH.Text!="" && txtSDT.Text!="" && txtMasp.Text!="" && txtsl.Text != "")
            {
                if(busBanDienThoai.insertHD(txtMaHD.Text, txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtMasp.Text, txtsl.Text))
                {
                    MessageBox.Show("Thêm hóa đơn thành công.", "Information");
                    dgvHoaDon.DataSource = busBanDienThoai.getHD();
                    busBanDienThoai.updateSL(Int32.Parse(txtsl.Text), txtMasp.Text);
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn, mã khách hàng, tên khách hàng, số điện thoại, mã sản phẩm hoặc số lượng đang trống, Hãy nhập giá trị", "Information");
                txtMaHD.Focus();
            }
        }
    }
}
