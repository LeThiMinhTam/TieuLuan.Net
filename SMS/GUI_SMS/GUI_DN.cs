using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_SMS;

namespace GUI_SMS
{
    public partial class GUI_DN : Form
    {
        BUS_DN bn = new BUS_DN();
        public GUI_DN()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            int i = bn.getDN(username, password);

            if (i == 1)
            {
                mySave.KT = !mySave.KT;
                MessageBox.Show("Log in successful","information");
                this.Close();
            }
            else
            {
                MessageBox.Show("username or password is not correct");
            }
           

        }

    }
}
