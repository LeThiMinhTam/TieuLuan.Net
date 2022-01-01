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
    public partial class GUI_DienThoai : Form
    {
        BUS_DienThoai busDienThoai = new BUS_DienThoai();
        bool tf, tf1;
        string masp;

        public GUI_DienThoai()
        {
            InitializeComponent();
            tf = tf1 = true;
            Lock_Unlock(tf);
            Lock_Unlock1(tf1);
        }

        void Lock_Unlock(bool tf)
        {
            btnNew.Enabled = tf;
            btnAdd.Enabled = txtMasp.Enabled = txtTensp.Enabled = txtSoluong.Enabled = txtGia.Enabled = !tf;
        }
        void Lock_Unlock1(bool tf1)
        {
            dgvDienthoai.Enabled = tf1;
            btnDelete.Enabled = btnUpdate.Enabled = txtMasp.Enabled = txtTensp.Enabled = txtSoluong.Enabled = txtGia.Enabled = !tf1;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtMasp.Text != "" && txtTensp.Text != "" && txtSoluong.Text != "" && txtGia.Text != "")
            {
                if (busDienThoai.insertDienThoai(txtMasp.Text, txtTensp.Text, txtSoluong.Text, txtGia.Text))
                {
                    MessageBox.Show("Chèn thành công.", "Information");
                    tf = !tf;
                    Lock_Unlock(tf);
                    dgvDienthoai.DataSource = busDienThoai.getDienThoai();
                }
                else
                {
                    MessageBox.Show("Chèn thất bại", "Information");
                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm , tên sản phẩm, số lượng hoặc giá đang trống, hãy nhập giá trị.", "Information");
                txtMasp.Focus();
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                Lock_Unlock(tf);
                txtMasp.Text = txtTensp.Text = txtSoluong.Text = txtGia.Text = "";
                txtMasp.Focus();
            }
            else
            {
                MessageBox.Show("Cập nhật hoặc xóa", "Information");
            }
        }

        private void dgvDienthoai_Click_1(object sender, EventArgs e)
        {
            if (tf)
            {
                int i = dgvDienthoai.CurrentRow.Index;
                masp = txtMasp.Text = dgvDienthoai[0, i].Value.ToString();

                txtTensp.Text = dgvDienthoai[1, i].Value.ToString();
                txtSoluong.Text = dgvDienthoai[2, i].Value.ToString();
                txtGia.Text = dgvDienthoai[3, i].Value.ToString();
                tf1 = !tf1;
                Lock_Unlock1(tf1);
            }
            else MessageBox.Show("Chèn!\nNhấn Reset để làm công việc khác.", "Information");
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtMasp.Text != "" && txtTensp.Text != "" && txtSoluong.Text != "" && txtGia.Text != "")
            {
                if (busDienThoai.updateDienThoai(masp, txtMasp.Text, txtTensp.Text, txtSoluong.Text, txtGia.Text))
                {
                    MessageBox.Show("Cập nhật thành công.", "Information");
                    tf1 = !tf1;
                    Lock_Unlock1(tf1);
                    dgvDienthoai.DataSource = busDienThoai.getDienThoai();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Information");
                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm , tên sản phẩm, số lượng hoặc giá đang trống, hãy nhập giá trị.", "Information");
                txtMasp.Focus();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (busDienThoai.deleteDienThoai(masp))
            {
                MessageBox.Show("Xóa thành công.", "Information");
                tf1 = !tf1;
                Lock_Unlock1(tf1);
                dgvDienthoai.DataSource = busDienThoai.getDienThoai();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Information");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            tf = tf1 = true;
            Lock_Unlock(tf);
            Lock_Unlock1(tf1);
        }

        private void GUI_DienThoai_Load(object sender, EventArgs e)
        {
            dgvDienthoai.DataSource = busDienThoai.getDienThoai();

        }
    }
}
