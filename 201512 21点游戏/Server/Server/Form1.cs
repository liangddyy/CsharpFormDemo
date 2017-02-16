using SocketServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplication1;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
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
            //返回到客户端的消息 返回1表示继续叫牌
            if (contentStr.Contains("连接成功"))
                return "1";
            else
                return rebackMsg(contentStr);

        }
        //处理返回的消息.是否继续要牌
        private string rebackMsg(string str)
        {
            int[] myArray = MyConvert.StringToArray(str);

            int computerSum = myArray[7];
            int playerSum = myArray[8];
            int k;

            //计算电脑实际总分..ACE
            if (myArray[1] >= 1)
            {
                k = computerSum + 9;
                if (k <= 21) computerSum = k;
            }
            if (myArray[1] >= 2)  // 最多只會有2張Ace當作10 否則會爆掉
            {
                k = computerSum + 9;
                if (k <= 21) computerSum = k;
            }

            //玩家实际分数(除去第一张)
            if (myArray[2] >= 1)
            {
                k = playerSum + 9;
                if (k <= 21) playerSum = k;
            }
            if (myArray[2] >= 2)  // 最多只會有2張Ace當作10 否則會爆掉
            {
                k = playerSum + 9;
                if (k <= 21) playerSum = k;
            }


            //玩家停牌和非停牌
            if (myArray[4] == 0)
            {
                if (computerSum > playerSum)
                {
                    this.Invoke(new Set_ContentText(GetContent), "停止要牌");
                    return "0";
                }
                else
                {
                    this.Invoke(new Set_ContentText(GetContent), "继续要牌");
                    return "1";
                }
            }
            else
            {
                if (computerSum <= 11)
                {
                    this.Invoke(new Set_ContentText(GetContent), "继续要牌");
                    return "1";
                }
                else if (computerSum <= 15)
                {
                    if (computerSum > playerSum - 2)
                    {
                        this.Invoke(new Set_ContentText(GetContent), "停止要牌");
                        return "0";
                    }
                    else
                    {
                        this.Invoke(new Set_ContentText(GetContent), "继续要牌");
                        return "1";
                    }
                }
                else if (computerSum <= 20)
                {
                    if (computerSum > playerSum)
                    {
                        this.Invoke(new Set_ContentText(GetContent), "停止要牌");
                        return "0";
                    }
                    else
                    {
                        this.Invoke(new Set_ContentText(GetContent), "继续要牌");
                        return "1";
                    }
                }
                else
                {
                    this.Invoke(new Set_ContentText(GetContent), "停止要牌");
                    return "0";
                }
            }

        }

        private void GetContent(string contentStr)
        {
            this.txtContent.Text += contentStr + Environment.NewLine;
        }


        private void Show_info(string contentStr)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Set_ContentText(GetContent), contentStr);
            }
        }
        private void cmbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ListenStop();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ListenStop();
            ListenStart();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
