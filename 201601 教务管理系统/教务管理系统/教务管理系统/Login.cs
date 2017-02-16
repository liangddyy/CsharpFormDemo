using AnimationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教务管理系统.学生模块;
using 教务管理系统.教务员模块;
using 教务管理系统.教师模块;
using 教务管理系统.菜单模块;

namespace 教务管理系统
{
    public partial class Login : Form
    {
        Opreate op = new Opreate();
        
        public void showFrm()
        {
            Show();
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new 菜单模块.教师主菜单();
            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_HIDE | Win32.AW_SLIDE))
            {
                //扩张特效显示
                //Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
                frm.ShowDialog(this);
            }
        }

        private void skinTextBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            //密码为空
            if (skinTextBox1.Text.Equals("") || skinTextBox2.Text.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            //密码不为空
            else
            {
                SqlConnection conn = new Opreate().conn();

                conn.Open();
                string strCmd;
                string indexPwd;
                string indexIdentity;//身份信息

                User.setuNo(skinTextBox1.Text.ToString());
                User.setuPwd(skinTextBox2.Text.ToString());
                User.setuProperties("教师");
                                
                if (radioTeacher.Checked)
                {

                    //可改为存储过程
                    strCmd = "select tname from teacher where tno='" + User.getuNo() + "'";
                    User.setuName(op.FiledValue(strCmd));

                    //用户名不存在
                    if (User.getuName() == "")
                    {
                        MessageBox.Show("用户不存在！");
                        skinTextBox1.Text = "";
                        skinTextBox2.Text = "";
                    }
                    else
                    {

                        strCmd = "select tpsw from teacher where tno='" + User.getuNo() + "'";
                        indexPwd = op.FiledValue(strCmd);

                        //密码正确
                        if (User.getuPwd().Equals(indexPwd))
                        {
                            //动画。切换菜单
                            Form frm = new 菜单模块.教师主菜单();
                            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_HIDE | Win32.AW_SLIDE))
                            {
                                //扩张特效显示
                                //Win32.AnimateWindow(frm.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
                                //frm.ShowDialog(this);
                                frm.Show();
                                this.Hide();
                            }

                        }
                        else
                        {
                            skinTextBox2.Text = "";
                            MessageBox.Show("密码不正确！");
                            return;
                        }
                    }

                }
                if (radioAdministrator.Checked)
                {
                    //可改为存储过程
                    strCmd = "select tname from teacher where tno='" + User.getuNo() + "'";
                    User.setuName(op.FiledValue(strCmd));

                    //用户名不存在
                    if (User.getuName() == "")
                    {
                        MessageBox.Show("用户不存在！");
                        skinTextBox1.Text = "";
                        skinTextBox2.Text = "";
                    }
                    else
                    {

                        strCmd = "select tpsw from teacher where tno='" + User.getuNo() + "'";
                        indexPwd = op.FiledValue(strCmd);

                        //密码正确.教师身份
                        if (User.getuPwd().Equals(indexPwd))
                        {
                            strCmd = "select tduties from teacher where tno='" + User.getuNo() + "'";
                            indexIdentity = op.FiledValue(strCmd);
                            if (indexIdentity.Equals("教务员")|| indexIdentity.Equals("管理员"))
                            {
                                Form frm = new 教务员菜单();
                                if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_HIDE | Win32.AW_SLIDE))
                                {
                                    //扩张特效显示
                                    //Win32.AnimateWindow(frm.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
                                    frm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("您不是管理员或教务员身份");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            skinTextBox2.Text = "";
                            MessageBox.Show("密码不正确！");
                            return;
                        }
                    }
                }
                if (radioStudent.Checked)
                {

                    //可改为存储过程
                    strCmd = "select sname from student where sno='" + User.getuNo() + "'";
                    User.setuName(op.FiledValue(strCmd));

                    //用户名不存在
                    if (User.getuName() == "")
                    {
                        MessageBox.Show("用户不存在！");
                        skinTextBox1.Text = "";
                        skinTextBox2.Text = "";
                    }
                    else
                    {

                        strCmd = "select spsw from student where sno='" + User.getuNo() + "'";
                        indexPwd = op.FiledValue(strCmd);

                        //密码正确
                        if (User.getuPwd().Equals(indexPwd))
                        {
                            //动画。切换菜单
                            Form frm = new 学生主菜单();
                            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_HIDE | Win32.AW_SLIDE))
                            {
                                //扩张特效显示
                                //Win32.AnimateWindow(frm.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
                                
                                frm.Show(this);
                                //this.Hide();
                            }

                        }
                        else
                        {
                            skinTextBox2.Text = "";
                            MessageBox.Show("密码不正确！");
                            return;
                        }
                    }
                }
                conn.Close();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //无标题窗口拖拽功能
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wparam, int lparam);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键            
            {
                Capture = false;//释放鼠标使能够手动操作                
                SendMessage(Handle, 0x00A1, 2, 0);//拖动窗体            
            }
        }
        //无标题窗口拖拽功能end
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        //鼠标从密码框移开后焦点跳到登陆
        private void skinTextBox2_Leave(object sender, EventArgs e)
        {
            skinButtonLogin.Focus();
        }

        private void skinButtonLogin_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
