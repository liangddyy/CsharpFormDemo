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
    public partial class Mange_Student : Form
    {
        public Mange_Student()
        {
            InitializeComponent();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Mange_Student_Look MSL = new Mange_Student_Look();
            MSL.Show();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Mange_Student_Add MSA = new Mange_Student_Add();
            MSA.Show();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            Mange_Student_Change MSC = new Mange_Student_Change();
            MSC.Show();
        }
    }
}
