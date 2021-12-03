using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_SMS
{
    public partial class GUI_Menu : Form
    {
        public GUI_Menu()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }

        void Lock_Unlock(Boolean kt)
        {
            mnuLogout.Enabled = mnuManage.Enabled = mnuSearch.Enabled = mnuPrint.Enabled = !kt;
            mnuLogin.Enabled = mnuClose.Enabled = kt;

        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            GUI_DN f = new GUI_DN();
            f.Show();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GUI_Menu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);

        }

        private void mnuSystem_Click(object sender, EventArgs e)
        {

        }
    }
}
