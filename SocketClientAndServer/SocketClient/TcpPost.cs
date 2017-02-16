using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace SocketClient
{
    public class TcpPost
    {
        /// <summary>
        /// 发送文本信息
        /// </summary>
        /// <param name="txtContent">要发送的文本信息</param>
        /// <param name="ipAdress">接收方地址</param>
        /// <param name="port">端口</param>
        /// <returns>返回信息</returns>
        public static string Start(string txtContent, string ipAdress, string portStr)
        {
            int port = Convert.ToInt32(portStr);

            TcpClient tcpclnt = new TcpClient();

            // 连接服务器

            try
            {
                tcpclnt.Connect(ipAdress, port);
                // 得到客户端的流
                Stream stm = tcpclnt.GetStream();

                // 发送字符串
                UTF8Encoding asen = new UTF8Encoding();
                byte[] ba = asen.GetBytes(txtContent);
                stm.Write(ba, 0, ba.Length);

                // 接收从服务器返回的信息
                byte[] stream = new byte[1024];
                int k = stm.Read(stream, 0, 1024);

                // 关闭客户端连接
                tcpclnt.Close();
                //获得返回消息
                string message = System.Text.Encoding.UTF8.GetString(stream, 0, k);
                //输出返回消息
                return message;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }



        }
    }
}
