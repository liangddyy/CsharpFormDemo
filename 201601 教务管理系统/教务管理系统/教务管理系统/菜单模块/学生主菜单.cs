using AnimationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教务管理系统.学生模块;

namespace 教务管理系统.菜单模块
{
    public partial class 学生主菜单 : Form
    {
        Opreate op = new Opreate();

        public Login frm1;
        
        public 学生主菜单()
        {
            InitializeComponent();
        }

        private void 学生主菜单_Load(object sender, EventArgs e)
        {
            this.Text = User.getuName() + "同学，欢迎您 - 福建工程学院教务管理系统";

            //公告栏初始化
            string strCmd = "SELECT TEXT from Notice WHERE datetime=(SELECT MAX(datetime) FROM Notice)";
            skinTextBox1.Text = op.FiledValue(strCmd);
            skinTextBox1.ReadOnly = true;

            //成绩查询初始化            
            //查询当前登录学生所学的科目的成绩
            DataTable dt = op.GetDataTable("SELECT c.cname, g.cno,t.tname,g.grade FROM grade g,course c,teacher t where g.cno=c.cno AND g.tno=t.tno AND sno='" + User.getuNo() + "'", "grade");
            skinDataGridView1.DataSource = dt;

            //课表查询初始化
            DataTable dt2 = op.GetDataTable("SELECT c.cname,t.tname,te.lesson_time,te.exam_time FROM Teacher_teaching te, teacher t, student s, grade g, course c where s.sno = g.sno AND g.cno = c.cno AND g.cno = te.cno AND te.tno = t.tno AND s.sno='" + User.getuNo() + "'", "stuCourse");
            skinDataGridView2.DataSource = dt2;

            //选课模块初始化
            List<string> selectCnoAndCname = op.getCnoAndCnameStu();
            comboBox1.Items.Clear();
            for (int i = 0; i < selectCnoAndCname.Count; i++)
            {
                comboBox1.Items.Add(selectCnoAndCname[i]);
            }
            hidePanel();
            panel_message.Show();         
        }
        void hidePanel()
        {
            panel_grade.Hide();
            panel_lesson.Hide();
            panel_message.Hide();
            panel_selectlesson.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string strCmd = "select count(*) from grade where sno='" + User.getuNo() + "' AND grade_prompt is null;";

            if (int.Parse(op.FiledValue(strCmd))>0){

                MessageBox.Show("您有未查看的成绩!");
                strCmd = "UPDATE grade SET grade_prompt ='1' where sno='" + User.getuNo() + "'AND grade_prompt is null;";
                if (op.OPSQL(strCmd))
                {
                    //timer1.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("未知错误");
                }
            }
        }

        private void ButtonLessonTime_Click(object sender, EventArgs e)
        {
            hidePanel();
            Win32.AnimateWindow(panel_lesson.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSelectCourse_Click(object sender, EventArgs e)
        {
            hidePanel();
            Win32.AnimateWindow(panel_selectlesson.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("请选择课程！");
                return;
            }
            else
            {
                string sno = User.getuNo();
                string cno = (comboBox1.Text.ToString().Split('-'))[0];

                //获取该课程的授课老师编号
                string sql = "select tno from Teacher_teaching where cno ='" + cno + "'";
                string tno = op.FiledValue(sql);
                if (tno != "")
                {
                    sql = "insert into grade(sno,cno,tno,grade_prompt)values ('" + sno + "','" + cno + "','" + tno + "','1');";
                    if (op.OPSQL(sql))
                    {
                        MessageBox.Show("选课成功");
                    }
                }
                else
                {
                    MessageBox.Show("该课程还未安排老师");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cno = (comboBox1.Text.ToString()).Split('-')[0];
            SqlConnection Conn = op.conn();//到sqlsever的连接 
            Conn.Open();
            string strCmd = "select credit from course where cno = '" + cno + "'";


            SqlCommand cmd = new SqlCommand(strCmd, Conn);
            textBox1.Text = cmd.ExecuteScalar().ToString();//C# 如何把数据库的查询语句查出来的值赋给某一变量
            textBox1.ReadOnly = true;
        }

        private void ButtonExam_Click(object sender, EventArgs e)
        {
            hidePanel();
            Win32.AnimateWindow(panel_grade.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = op.GetDataTable("SELECT c.cname, g.cno,t.tname,g.grade FROM grade g,course c,teacher t where g.cno=c.cno AND g.tno=t.tno AND sno='" + User.getuNo() + "'", "grade");
            skinDataGridView1.DataSource = dt;
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            DataTable dt2 = op.GetDataTable("SELECT c.cname,t.tname,te.lesson_time,te.exam_time FROM Teacher_teaching te, teacher t, student s, grade g, course c where s.sno = g.sno AND g.cno = c.cno AND g.cno = te.cno AND te.tno = t.tno AND s.sno='" + User.getuNo() + "'", "stuCourse");
            skinDataGridView2.DataSource = dt2;
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            string strCmd = "SELECT TEXT from Notice WHERE datetime=(SELECT MAX(datetime) FROM Notice)";
            skinTextBox1.Text = op.FiledValue(strCmd);
            skinTextBox1.ReadOnly = true;

            hidePanel();
            panel_message.Show();
        }
    }
}
