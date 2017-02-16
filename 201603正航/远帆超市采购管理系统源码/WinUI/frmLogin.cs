using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BIL;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using model;



namespace WinUI
{
   
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtName.Text.Length == 0)
                    throw new MessageException("用户名不能为空！");
                else if (this.txtPwd.Text == "")
                    throw new MessageException("密码不能为空！");
                UserData u = UserCortrol.login(this.txtName.Text, this.txtPwd.Text);
                Set.User = u;
                this.DialogResult = DialogResult.Yes;
            }
            catch (SqlException)
            {
                DialogResult dr = MessageBox.Show("连接到SqlServer服务器失败！\n是否进行服务器配置？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                frmSqlSet fss = new frmSqlSet();
                fss.ShowDialog();
            }
            catch (MessageException ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            UserCortrol.setConn(Set.set.SqlServerName, Set.set.SqlUser, Set.set.SqlPwd);
        }

    }
}