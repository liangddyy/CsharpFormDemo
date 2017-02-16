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
using _201604RFID.Loc;

namespace _201604RFID.View
{
    public partial class setAchor : Form
    {
        public setAchor()
        {
            InitializeComponent();
        }

        private void setAchor_Load(object sender, EventArgs e)
        {
            textBox1.Text = MyPointP.p1.X.ToString();
            textBox2.Text = MyPointP.p1.Y.ToString();
            textBox3.Text = MyPointP.p2.X.ToString();
            textBox4.Text = MyPointP.p2.Y.ToString();
            textBox5.Text = MyPointP.p3.X.ToString();
            textBox6.Text = MyPointP.p3.Y.ToString();
            textBox7.Text = MyPointP.p4.X.ToString();
            textBox8.Text = MyPointP.p4.Y.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyPointP.p1.X = int.Parse(textBox1.Text.ToString());
            MyPointP.p1.Y = int.Parse(textBox2.Text.ToString());

            MyPointP.p2.X = int.Parse(textBox3.Text.ToString());
            MyPointP.p2.Y = int.Parse(textBox4.Text.ToString());
            MyPointP.p3.X = int.Parse(textBox5.Text.ToString());
            MyPointP.p3.Y = int.Parse(textBox6.Text.ToString());
            MyPointP.p4.X = int.Parse(textBox7.Text.ToString());
            MyPointP.p4.Y = int.Parse(textBox8.Text.ToString());
            this.Close();

        }
    }
}
