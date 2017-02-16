using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学籍管理_demo.成绩管理;
using 学籍管理_demo.课程管理;

namespace 学籍管理_demo
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }
        
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new addStudentFrm();
            frm2.ShowDialog(this);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                
                Application.Exit();//退出整个应用程序
            }
            else
            {
                e.Cancel = true;  //取消关闭事件
            }
        }

        private void 学籍信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = new delStudentFrm();
            
            frm3.ShowDialog(this);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCourseFind = new 课程信息查询();
            frmCourseFind.ShowDialog(this);
        }

        private void 添加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmCourseAdd = new 课程信息添加();

            frmCourseAdd.ShowDialog(this);
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCourseModify = new 课程信息修改();
            frmCourseModify.ShowDialog(this);
        }

        private void 添加ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frmScoreAdd = new 成绩信息添加();
            frmScoreAdd.ShowDialog(this);
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmScoreModify = new 成绩信息修改();
            frmScoreModify.ShowDialog(this);
        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmScoreFind = new 学生成绩查询();
            frmScoreFind.ShowDialog(this);
        }
    }
}
