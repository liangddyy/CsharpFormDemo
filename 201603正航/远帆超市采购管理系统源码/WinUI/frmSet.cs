using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using BIL;
namespace WinUI
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Set.set.ChaoName = this.txtName.Text;
                Set.set.interval = Convert.ToInt32(this.txtinterval.Text);
                Set.set.SmtpServer = this.txtSmtp.Text;
                Set.set.SmtpUser = this.txtUser.Text;
                Set.set.SmtpPwd = this.txtPWD.Text;
                Set.XmlSerializer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }



        private void frmSet_Load(object sender, EventArgs e)
        {
            this.txtName.Text = Set.set.ChaoName;
            this.txtinterval.Text = Set.set.interval.ToString();
            this.txtSmtp.Text = Set.set.SmtpServer;
            this.txtUser.Text = Set.set.SmtpUser;
            this.txtPWD.Text = Set.set.SmtpPwd;
        }
    }
}