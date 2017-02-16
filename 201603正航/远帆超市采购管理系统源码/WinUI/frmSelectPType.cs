using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BIL;
namespace WinUI
{
    public partial class frmSelectPType : Form
    {
        public frmSelectPType()
        {
            InitializeComponent();
        }
        bool ok = false;
        public Object ShowSelect()
        {
            this.ShowDialog();
            if (this.pTypeListBox1.lbPType.SelectedIndex == -1)
                throw new MessageException("");
            if (ok == false)
                throw new MessageException("");
            return this.pTypeListBox1.lbPType.SelectedItem;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.pTypeListBox1.fillList(this.textBox1.Text);
        }

        private void frmSelectPType_Load(object sender, EventArgs e)
        {
            this.pTypeListBox1.lbPType.DoubleClick += new EventHandler(lbPType_DoubleClick);
        }

        void lbPType_DoubleClick(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }
    }
}