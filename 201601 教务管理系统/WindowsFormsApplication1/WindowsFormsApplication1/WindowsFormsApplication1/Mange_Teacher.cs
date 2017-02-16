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
    public partial class Mange_Teacher : Form
    {
        public Mange_Teacher()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Mange_Teacher_Add MTA = new Mange_Teacher_Add();
            MTA.Show();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Mange_Teacher_Look MTL = new Mange_Teacher_Look();
            MTL.Show();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            Mange_Teacher_Change MTC = new Mange_Teacher_Change();
            MTC.Show();
        }
    }
}
