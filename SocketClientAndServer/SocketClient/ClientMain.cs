using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SocketClient
{
    public partial class ClientMain : Form
    {
        public ClientMain()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            
            bool checkResult = CheckMessage();
            if (checkResult)
            {
                string cmd = cmbCommand.Text;
                txtShowInfo.Text += TcpPost.Start(cmd, txtAdress.Text, txtPort.Text) + Environment.NewLine;
                
            }
        }

        private bool CheckMessage()
        {
            bool boolresult = true;
            if (!IPCheck(txtAdress.Text))
            {
                boolresult = false;
                lblShowText.Text="IP地址为空或者格式不正确";
            }
            if (string.IsNullOrEmpty(txtPort.Text) || !CheckInt(txtPort.Text))
            {
                boolresult = false;
                lblShowText.Text = "端口为空或者格式不正确";
            }
            if (string.IsNullOrEmpty(cmbCommand.Text))
            {
                boolresult = false;
                lblShowText.Text = "发送信息为空";
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

        private void ClientMain_Load(object sender, EventArgs e)
        {
            cmbCommand.SelectedIndex = 0;
        }

        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
