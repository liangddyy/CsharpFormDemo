using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ThreadServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpListener tcpListener;
        TcpClient tcpClient;
        Thread thread;

        delegate void SetTextCallback(string str);

        private void SetText(string str)
        {
            textBox1.AppendText(str + "\r\n");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8000);

            this.Invoke(new SetTextCallback(SetText), new object[] { "启动侦听" });
            tcpListener.Start();
            tcpClient = tcpListener.AcceptTcpClient();
            this.Invoke(new SetTextCallback(SetText), new object[] { "服务器已有连接" });
            
            thread = new Thread(new ThreadStart(Process));
            thread.Start();
        }
        
        private void Process()
        {
            byte[] btServerReceive = new byte[256];				//定义byte数组
            byte[] btServerSend = new byte[256];				//定义byte数组
            string strServerReceive = "";						//定义空字符串
            NetworkStream ns;

            int succ;

            try
            {
                while (true)
                {
                    ns = tcpClient.GetStream();			//获取客户端发送的网络流
                    int len = ns.Read(btServerReceive, 0, btServerReceive.Length);//字节长度
                    strServerReceive = UnicodeEncoding.Unicode.GetString(btServerReceive, 0, len);//读取传递过来的值

                    this.Invoke(new SetTextCallback(SetText), new object[] { "收到:" + strServerReceive });
                    if (strServerReceive == "END")
                    {
                        break;
                    }
                    else
                    {
                        if (strServerReceive == "123abc456")//验证注册码字符串。
                        {
                            succ = 1;
                        }
                        else
                        {
                            succ = 0;
                        }
                    }
                    btServerSend[0] = (byte)succ;
                    ns.Write(btServerSend, 0, 1);

                    this.Invoke(new SetTextCallback(SetText), new object[] { "回传:" + btServerSend[0].ToString() });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Close();
                thread.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
