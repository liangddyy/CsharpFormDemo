using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ESCToCloseForm
{
    public partial class Frm_Main : Form
    {
        

        public Frm_Main()
        {
            InitializeComponent();
        }
 
        //3.判断输入键值（实现KeyDown事件）
        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)//判断如果按下的是ESC键
            {
                if (MessageBox.Show("是否要退出程序","信息提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    Application.Exit();//退出应用程序
                }
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            KeyboardHook k_hook = new KeyboardHook();
            k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);//钩住键按下
            k_hook.Start();//安装键盘钩子
        }
    }
}