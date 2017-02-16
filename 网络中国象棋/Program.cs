using System;
using System.Windows.Forms;

namespace 网络象棋
{
    internal static class Program
    {
        /// <summary>
        ///   应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frmchess()); //new Fu_pan() );
        }
    }
}