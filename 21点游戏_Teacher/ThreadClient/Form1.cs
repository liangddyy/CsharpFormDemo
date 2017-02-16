using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;	// 引用命名空间
using System.Net;

namespace ThreadClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        NetworkStream ns;
        TcpClient client=new TcpClient();
        private void btnSend_Click(object sender, EventArgs e)
		{
			string msg = "";
			if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
			{
				msg = textBox1.Text + textBox2.Text + textBox3.Text;
			}
			else
			{
                MessageBox.Show("请输入注册码", "客户端");
				return;
			}
            //ns = new NetworkStream();
           // if (!client.GetStream().Equals(null)) 
            ns = client.GetStream();
           // ns = new NetworkStream(client.GetStream());
			byte[] buffer = Encoding.Unicode.GetBytes(msg); // 获得缓存,把字符串转化为可以发送的流. 
			ns.Write(buffer, 0, buffer.Length); // 发往服务器 

            byte[] btClientReceive = new byte[256];				//定义byte数组

            int succ;

            int len = ns.Read(btClientReceive, 0, 1);
            succ = btClientReceive[0];

            if (succ == 1)
            {
                MessageBox.Show("注册码正确！");	//提示信息
            }
            else
            {
                MessageBox.Show("注册码错误！");
            }
   		}
        
		private void btnClear_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}

        private void button1_Click(object sender, EventArgs e)
        {
            client.Close();
            this.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            client = new TcpClient();			//创建TcpClient对象
            client.Connect("127.0.0.1", 8000);		//与指定设备进行连接
            // client.Connect("10.10.122.182", 8000);		//与指定设备进行连接
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes("END"); // 获得缓存,把字符串转化为可以发送的流. 
            ns.Write(buffer, 0, buffer.Length); // 发往服务器 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
