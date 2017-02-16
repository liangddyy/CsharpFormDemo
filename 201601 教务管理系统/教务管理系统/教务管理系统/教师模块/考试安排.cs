using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务管理系统.教师模块
{
    public partial class 考试安排 : Form
    {
        public 考试安排()
        {
            InitializeComponent();
        }
        Opreate op = new Opreate();

        private void 考试安排_Load(object sender, EventArgs e)
        {
            List<string> selectCnoAndCname = op.getCnoAndCname(skinComboBox1.Text.ToString());
            skinComboBox1.Items.Clear();
            for (int i = 0; i < selectCnoAndCname.Count; i++)
            {
                skinComboBox1.Items.Add(selectCnoAndCname[i]);
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (skinComboBox1.SelectedItem.ToString()=="")
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

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
