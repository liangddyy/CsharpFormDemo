using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SocketServer
{
    public delegate string On_read(byte[] buffer, int bytesRead);
    public delegate void Show_Info(string info);
   
    public class AsynSocketListener
    {
        //ManualResetEvent 是一线程用来控制别一个线程的信号。
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        private string ServerIP;
        private int ServerPort;
        private Socket listener;
        public event On_read Onread;
        public event Show_Info ShowInfo;
        public static bool Status = true;
        public AsynSocketListener(string serverIP, int serverPort)
        {
            this.ServerIP = serverIP;
            this.ServerPort = serverPort;
        }

        //监听停止
        public void ListenStop()
        {
            allDone.Close();
            Status = false;
        }

        //监听 主要部分
        public void TxtListen()
        {
            Status = true;
            IPAddress ipAddress = IPAddress.Parse(ServerIP);
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, ServerPort);

            listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);
                ShowInfo("监听开始");

                while (Status)
                {
                    // Set the event to nonsignaled state. 
                    allDone.Reset();
                    // Start an asynchronous socket to listen for connections. 
                    //Console.WriteLine("Waiting for a connection..."); 
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);
                    // Wait until a connection is made before continuing. 
                    allDone.WaitOne();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteError(ex.ToString());
            }
        }
        private void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue. 
            allDone.Set();
            // Get the socket that handles the client request. 
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);
            // Create the state object. 
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }
        private void ReadCallback(IAsyncResult ar)
        {


            try
            {
                String content = String.Empty;
                // Retrieve the state object and the handler socket创建自定义的状态对象 from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket handler = state.workSocket;//处理的句柄
                // Read data from the client socket. 读出



                int bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                {

                    //  string result = DoSomeThing(state.buffer, bytesRead);
                    //发送到客户端
                    string result = Onread(state.buffer, bytesRead);
                    //  Logger.WriteError(result);
                    Send(handler, result);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteError(ex.Message);
            }

        }


        //发送回传结果
        private void Send(Socket handler, String data)
        {
            //   Logger.WriteError(System.DateTime.Now.ToString() + "	" + data); 

            // Convert the string data to byte data using UTF8 encoding. 
            byte[] byteData = Encoding.UTF8.GetBytes(data);
            // Begin sending the data to the remote device. 
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }
        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object. 
                Socket handler = (Socket)ar.AsyncState;
                // Complete sending the data to the remote device. 
                int bytesSent = handler.EndSend(ar);
                //Console.WriteLine("Sent {0} bytes to client.", bytesSent); 
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Logger.WriteError(e.ToString());
            }
        }
    }
}
