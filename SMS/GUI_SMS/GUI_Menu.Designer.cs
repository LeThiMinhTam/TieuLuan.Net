
namespace GUI_SMS
{
    partial class GUI_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuManage,
            this.mnuSearch,
            this.mnuPrint});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuLogout,
            this.mnuClose});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(57, 20);
            this.mnuSystem.Text = "System";
            this.mnuSystem.Click += new System.EventHandler(this.mnuSystem_Click);
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(180, 22);
            this.mnuLogin.Text = "Log in";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(180, 22);
            this.mnuLogout.Text = "Log out";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(180, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuManage
            // 
            this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudent,
            this.mnuSubject});
            this.mnuManage.Name = "mnuManage";
            this.mnuManage.Size = new System.Drawing.Size(62, 20);
            this.mnuManage.Text = "Manage";
            // 
            // mnuStudent
            // 
            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Size = new System.Drawing.Size(180, 22);
            this.mnuStudent.Text = "Student";
            // 
            // mnuSubject
            // 
            this.mnuSubject.Name = "mnuSubject";
            this.mnuSubject.Size = new System.Drawing.Size(180, 22);
            this.mnuSubject.Text = "Subject";
            // 
            // mnuSearch
            // 
            this.mnuSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearch1,
            this.mnuSearch2});
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(54, 20);
            this.mnuSearch.Text = "Search";
            // 
            // mnuSearch1
            // 
            this.mnuSearch1.Name = "mnuSearch1";
            this.mnuSearch1.Size = new System.Drawing.Size(180, 22);
            this.mnuSearch1.Text = "Search1";
            // 
            // mnuSearch2
            // 
            this.mnuSearch2.Name = "mnuSearch2";
            this.mnuSearch2.Size = new System.Drawing.Size(180, 22);
            this.mnuSearch2.Text = "Search2";
            // 
            // mnuPrint
            // 
            this.mnuPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrint1,
            this.mnuPrint2});
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(44, 20);
            this.mnuPrint.Text = "Print";
            // 
            // mnuPrint1
            // 
            this.mnuPrint1.Name = "mnuPrint1";
            this.mnuPrint1.Size = new System.Drawing.Size(180, 22);
            this.mnuPrint1.Text = "Print1";
            // 
            // mnuPrint2
            // 
            this.mnuPrint2.Name = "mnuPrint2";
            this.mnuPrint2.Size = new System.Drawing.Size(180, 22);
            this.mnuPrint2.Text = "Print2";
            // 
            // GUI_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 278);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_Menu";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.GUI_Menu_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuSubject;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch1;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch2;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint1;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint2;
    }
}

