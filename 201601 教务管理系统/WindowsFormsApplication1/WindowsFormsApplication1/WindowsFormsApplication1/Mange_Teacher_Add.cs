using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Mange_Teacher_Add : Form
    {
        Opreate op = new Opreate();

        public Mange_Teacher_Add()
        {
            InitializeComponent();
        }

        private void skinLabel5_Click(object sender, EventArgs e)
        {

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (skinTextBox1.Text != "")
            {
                
                string sql = "insert into teacher(tno,tname,tsex,tduties) values('" + skinTextBox1.Text + "','"
                + skinTextBox2.Text + "','" + skinComboBox1.SelectedItem + "','"
                + skinComboBox2.SelectedItem + "')";


                if (op.OPSQL(sql))
                {
                    //ClearText();
                    MessageBox.Show("新建成功！");
                }
                else
                {
                    MessageBox.Show("创建失败！");
                }
            }
            else
            {
                MessageBox.Show("信息输入不全！");
            }
        }
    }
}
