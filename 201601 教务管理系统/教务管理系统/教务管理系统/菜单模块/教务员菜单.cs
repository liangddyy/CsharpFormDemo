using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教务管理系统.教务员模块;

namespace 教务管理系统.菜单模块
{
    public partial class 教务员菜单 : Form
    {
        public 教务员菜单()
        {
            InitializeComponent();
        }

        private void ButtonTeacher_Click(object sender, EventArgs e)
        {
            Form frm = new 教师信息管理();
            frm.ShowDialog(this);
        }

        private void ButtonStuGraduate_Click(object sender, EventArgs e)
        {
            Form frm = new 毕业生查询();
            frm.ShowDialog(this);
        }

        private void ButtonClass_Click(object sender, EventArgs e)
        {
            Form frm = new 排课();
            frm.ShowDialog(this);
        }

        private void 教务员菜单_Load(object sender, EventArgs e)
        {
            this.Text = User.getuName() + ",欢迎您 - 福建工程学院教务管理系统";
        }

        private void ButtonStudent_Click(object sender, EventArgs e)
        {
            Form frm = new 学生信息管理();
            frm.ShowDialog(this);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Form frm = new 公告栏();
            frm.ShowDialog(this);
        }
    }
}
