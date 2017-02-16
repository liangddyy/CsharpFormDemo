using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 我的测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void ManageTaskManager(int arg)
        {
             RegistryKey currentUser = Registry.CurrentUser;
             RegistryKey system = currentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
             //如果system项不存在就创建这个项
             if (system == null)
             {
                 system = currentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
             }
             system.SetValue("DisableTaskmgr", arg, RegistryValueKind.DWord);
             currentUser.Close();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageTaskManager(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageTaskManager(0);
        }
    }
}
