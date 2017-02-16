using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理_demo.成绩管理
{
    public partial class 成绩信息添加 : Form
    {
        Opreate op = new Opreate();
        public 成绩信息添加()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            List<string> selectSnoAndName = op.retSnoAndNameFromMajor(comboBox1.Text.ToString());
            comboBox2.Items.Clear();
            for (int i = 0; i < selectSnoAndName.Count; i++)
            {
                comboBox2.Items.Add(selectSnoAndName[i]);
            }
            comboBox2.Text = "";
            selectCourse.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, "^[1-9]"))
            {
                MessageBox.Show("输入正确的学分!", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string sno = (comboBox2.Text.ToString()).Split('-')[0];
                string cno = (selectCourse.Text.ToString().Split('-'))[0];
                string sql = "insert into score(sno,cno,grade) values('" + sno + " ','" + cno + " '," + textBox1.Text.ToString() + ")";
                //insert into course(cno, cname, ccategory, credit)
                if (op.OPSQL(sql))
                {
                    ClearText();
                    MessageBox.Show("新建成功！");
                }
                else
                {
                    MessageBox.Show("创建失败！");
                }
            }
        }
        public void ClearText()//清空数据
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            selectCourse.Text = "";
            textBox1.Text = "";
        }
        private void 成绩信息添加_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] snoAndName = (comboBox2.Text.ToString()).Split('-');
            List<string> selectCnoAndCname = op.retCnoAndCname(snoAndName[0]);
            selectCourse.Items.Clear();
            for (int i = 0; i < selectCnoAndCname.Count; i++)
            {
                selectCourse.Items.Add(selectCnoAndCname[i]);
            }
            selectCourse.Text = "";
            textBox1.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectCorse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
