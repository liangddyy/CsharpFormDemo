using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BIL;
namespace WinUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //获取设置

            Set.path = Application.StartupPath + @"\Set.XML";
            Set.XmlDeserialize();

            frmLogin frm = new frmLogin();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Yes)
                Application.Run(new frmMain());
        }


    }
}
///5/1/a/s/p/x/