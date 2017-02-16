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
    public partial class Mange_index : Form
    {
        public Mange_index()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mange_Class_Add MCA = new Mange_Class_Add();
            MCA.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mange_News MN = new Mange_News();
            MN.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mange_Student MS = new Mange_Student();
            MS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mange_Teacher MT = new Mange_Teacher();
            MT.Show();
        }
    }
}
