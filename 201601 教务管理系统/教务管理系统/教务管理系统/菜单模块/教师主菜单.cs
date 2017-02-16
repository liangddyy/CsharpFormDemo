using AnimationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教务管理系统.教师模块;

namespace 教务管理系统.菜单模块
{
    public partial class 教师主菜单 : Form
    {
        Opreate op = new Opreate();
        public 教师主菜单()
        {
            InitializeComponent();
        }

        private void 教师主菜单_Load(object sender, EventArgs e)
        {
            this.Text= User.getuName() + ",欢迎您 - 福建工程学院教务管理系统";

            //初始化考试安排
            List<string> selectCnoAndCname = op.getCnoAndCname(skinComboBox1.Text.ToString());
            skinComboBox1.Items.Clear();
            for (int i = 0; i < selectCnoAndCname.Count; i++)
            {
                skinComboBox1.Items.Add(selectCnoAndCname[i]);
            }
            panel1.Hide();

           
        }
        private void ButtonExam_Click(object sender, EventArgs e)
        {
            //Form frm = new 考试安排();
            //frm.ShowDialog(this);            

            panel1.Hide();
            //扩张特效显示
            Win32.AnimateWindow(panel1.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            Form frm = new 成绩录入();
            frm.ShowDialog(this);

            //panel1.Hide();
            //Win32.AnimateWindow(panel2.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (skinComboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("请选择课程！");
                return;
            }
            else
            {
                string tno = User.getuNo();
                string cno = (skinComboBox1.Text.ToString().Split('-'))[0];

                string sql = "update Teacher_teaching set exam_time = '" + dateTimePicker1.Value + "' where cno = '" + cno + "' and tno = '" + tno + "';";
                //insert into course(cno, cname, ccategory, credit)
                if (op.OPSQL(sql))
                {
                    //ClearText();
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
        }

        
    }
}
