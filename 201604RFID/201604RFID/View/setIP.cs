using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _201604RFID.Ctrl;

namespace _201604RFID.View
{
    public partial class setIP : Form
    {
        
        public setIP()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择IP文件保存路径";

            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                textBox_path_id.Text = dilog.SelectedPath+"\\IP.txt";
                textBox_path_id.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string []lines = {tID1.Text.ToString(), tIP01.Text.ToString(),tIP02.Text.ToString(), tIP03.Text.ToString(), tIP04.Text.ToString(), tID2.Text.ToString(), tIP11.Text.ToString(), tIP12.Text.ToString(), tIP13.Text.ToString(), tIP14.Text.ToString(), tID3.Text.ToString(), tIP21.Text.ToString(), tIP22.Text.ToString(), tIP23.Text.ToString(), tIP24.Text.ToString(), tID4.Text.ToString(), tIP31.Text.ToString(), tIP32.Text.ToString(), textBox14.Text.ToString(), textBox13.Text.ToString() };

            if (textBox_path_id.Enabled == false)
                MsgManager.saveIPmsg("IP.txt".ToString(), lines);
            else
            {
                MsgManager.saveIPmsg(textBox_path_id.Text.ToString(), lines);
            }
            MessageBox.Show("设置成功");
            this.Close();
        }

        private void setIP_Load(object sender, EventArgs e)
        {

        }
    }
}
