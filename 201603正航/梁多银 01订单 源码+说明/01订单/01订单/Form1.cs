using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using _01订单.数据库;

namespace _01订单
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new OrderAdd();
            frm.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
