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
    public partial class frmInput : Form
    {

        private void frmInput_Load(object sender, EventArgs e)
        {
            
        }

        public string ShowInput()
        {
            this.ShowDialog();
            if (this.textBox1.Text.Length == 0)
                throw new MessageException("");
            else
                return this.textBox1.Text;
        }

        public frmInput(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        public frmInput(string title, string text)
        {
            InitializeComponent();
            this.Text = title;
            this.textBox1.Text = text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}