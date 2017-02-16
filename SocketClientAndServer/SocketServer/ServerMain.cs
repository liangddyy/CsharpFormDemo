using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace SocketServer
{
    public partial class ServerMain : Form
    {
        public ServerMain()
        {
            InitializeComponent();
        }
        private delegate void Set_ContentText(string contentStr);

        private AsynSocketListener listener;

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool checkResult = CheckMessage();
            if (checkResult)
            {
                ListenStart();
            }
        }
        private bool CheckMessage()
        {
            bool boolresult = true;
            if (!IPCheck(cmbAddress.Text))
            {
                boolresult = false;
                lblShowText.Text = "IP地址为空或者格式不正确";
            }
            if (string.IsNullOrEmpty(txtPort.Text) || !CheckInt(txtPort.Text))
            {
                boolresult = false;
                lblShowText.Text = "端口为空或者格式不正确";
            }

            return boolresult;
        }

        private bool CheckInt(string p)
        {
            bool boolresult = true;
            try
            {
                Convert.ToInt32(p);
            }
            catch
            {
                boolresult = false;
            }
            return boolresult;
        }
        private bool IPCheck(string ip)
        {

            string num = "(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)";

            return Regex.IsMatch(ip, ("^" + num + "\\." + num + "\\." + num + "\\." + num + "$"));
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            ListenStop();
        }
        /// <summary> 
        ///保持字幕文件滚动条始终在最下
        /// </summary> 
        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            this.txtContent.SelectionStart = this.txtContent.Text.Length;
            this.txtContent.SelectionLength = 0;
            this.txtContent.ScrollToCaret();
        }

        private void ListenStart()
        {
            this.listener = new AsynSocketListener(this.cmbAddress.Text, Convert.ToInt32(this.txtPort.Text));
            listener.Onread += new On_read(listener_Onread);
            listener.ShowInfo += new Show_Info(Show_info);
            
            //监听线程
            Thread tdListen = new Thread(listener.TxtListen);
            tdListen.Name = "tdListen";
            tdListen.Start();
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.cmbAddress.Enabled = false;
            this.txtPort.Enabled = false;
        }

        private void ListenStop()
        {
            listener.ListenStop();
            listener = null;
            GC.Collect();
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            this.cmbAddress.Enabled = true;
            this.txtPort.Enabled = true;
        }

        private string listener_Onread(byte[] buffer, int bytesRead)
        {
            //接收客户端的信息，并返回提示到客户端
            string contentStr = (Encoding.UTF8.GetString(buffer, 0, bytesRead));
            if (InvokeRequired)
            {
                this.Invoke(new Set_ContentText(GetContent), contentStr);
            }
            return "发送成功";
        }

        private void GetContent(string contentStr)
        {
            this.txtContent.Text += contentStr+Environment.NewLine;
        }


        private void Show_info(string contentStr)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Set_ContentText(GetContent), contentStr);
            }
        }

        private void ServerMain_Load(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;

            string strHostName = Dns.GetHostName(); //得到本机的主机名
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName); //取得本机IP
            foreach (System.Net.IPAddress ip in ipEntry.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    cmbAddress.Items.Add(ip.ToString());
                }

            }
        }

        private void txtContent_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
