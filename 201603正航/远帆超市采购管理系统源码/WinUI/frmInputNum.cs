using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinUI
{
    public delegate void InputNum(char num);
    
    public partial class frmInputNum : Form
    {
        /// <summary>
        /// 构造数字输入框
        /// </summary>
        /// <param name="point">是否显示小数点</param>
        /// <param name="p">坐标</param>
        public frmInputNum(bool ShowPoint, Point p)
        {
            InitializeComponent();
            if (ShowPoint == false)
                this.btnPoint.Enabled = false;
            this.Left = p.X;
            this.Top = p.Y;
        }

        private void frmInputNum_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        
        

        public event InputNum OnInput;

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            OnInput(Convert.ToChar(btn.Tag));
        }


    }
}