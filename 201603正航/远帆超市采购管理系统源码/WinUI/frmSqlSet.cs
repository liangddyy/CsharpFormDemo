using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BIL;

namespace WinUI
{
    public partial class frmSqlSet : Form
    {
        public frmSqlSet()
        {
            InitializeComponent();
        }

        private void frmSqlSet_Load(object sender, EventArgs e)
        {
            this.txtServer.Text = Set.set.SqlServerName;
            this.txtUser.Text = Set.set.SqlUser;
            this.txtPwd.Text = Set.set.SqlPwd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set.set.SqlServerName = this.txtServer.Text;
            Set.set.SqlUser = this.txtUser.Text;
            Set.set.SqlPwd = this.txtPwd.Text;
            UserCortrol.setConn(Set.set.SqlServerName, Set.set.SqlUser, Set.set.SqlPwd);
            Set.XmlSerializer();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}