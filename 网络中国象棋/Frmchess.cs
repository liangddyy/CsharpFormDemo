using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

//add

namespace 网络象棋
{
    public partial class Frmchess : Form
    {
        public const short REDPLAYER = 1;
        public const short BLACKPLAYER = 0;
        private readonly ArrayList StepList = new ArrayList(); //保存全部走棋信息 
        private bool IsMyTurn = true; //IsMyTurn判断是否该自己走了 
        public short LocalPlayer; //LocalPlayer记录自己是红方还是黑方
        //网络通信部分         
        private bool ReadFlag = true; //设定侦听标示位，通过它来设定是否侦听端口号        
        private ArrayList StepList2 = new ArrayList(); //保存全部走棋信息含坐标   
        private ChessBoard chessboard;
        private bool first = true; //区分第一次跟第二次选中的棋子
        private Chess firstChess2; //鼠标单击时选定的棋子
        private IPEndPoint remote; //定义一个远程结点用以获取远程计算机发送的信息      
        private Chess secondChess2;
        private int tempx, tempy;
        private Thread th; //定义一个线程，在线程接收信息        
        private UdpClient udpclient; //创建一个UDP网络服务        
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public Frmchess()
        {
            InitializeComponent();
            //不捕获线程控件调用异常
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chessboard = new ChessBoard();
            chessboard.winHandle = picBoard.Handle;
            picBoard.BackgroundImage = new Bitmap(360, 400);
            chessboard.bufferImage = picBoard.BackgroundImage;
            chessboard.reDraw();
            //LocalPlayer = REDPLAYER;
            //if (LocalPlayer == BLACKPLAYER)
            //    SetMyTurn(false); 
            //chessboard.NewGame(LocalPlayer); 
        }

        /*解析鼠标之下的棋子对象*/

        private Chess analyse(int x, int y)
        {
            tempx = (int) Math.Floor((double) x/40) + 1;
            tempy = (int) Math.Floor((double) y/40) + 1;
            //防止超出范围
            if (tempx > 9 || tempy > 10 || tempx < 0 || tempy < 0)
                return null;
            else
            {
                int idx = chessboard.Map[tempx, tempy];
                if (idx == -1) return null;
                return chessboard.chess[idx];
            }
        }

        private bool IsMyChess(int idx)
        {
            bool functionReturnValue = false;
            if (idx >= 0 && idx < 16 && LocalPlayer == BLACKPLAYER)
                functionReturnValue = true;
            if (idx >= 16 && idx < 32 && LocalPlayer == REDPLAYER)
                functionReturnValue = true;
            return functionReturnValue;
        }

        private void picBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsMyTurn == false) return;
            int idx, idx2; //保存第一次和第二次被单击棋子的索引号
            if (first)
            {
                //第一次棋子
                firstChess2 = analyse(e.X, e.Y);
                x1 = tempx;
                y1 = tempy;
                if (firstChess2 != null)
                {
                    if (firstChess2.player != LocalPlayer)
                    {
                        toolStripStatusLabel1.Text = "单击成对方棋子了!";
                        return;
                    }
                    first = false;
                    firstChess2.DrawSelectedChess(picBoard.CreateGraphics());
                }
            }
            else
            {
                //第2次棋子
                secondChess2 = analyse(e.X, e.Y);
                x2 = tempx;
                y2 = tempy;
                //如果是自己的棋子,则换上次选择的棋子 
                if (secondChess2 != null)
                {
                    Graphics g = picBoard.CreateGraphics();
                    if (secondChess2.player == LocalPlayer)
                    {
                        //取消上次选择的棋子,颜色恢复                        
                        firstChess2.UnDrawSelectedChess(g, Color.White);
                        firstChess2 = secondChess2;
                        x1 = tempx;
                        y1 = tempy;
                        //设置选择的棋子颜色
                        firstChess2.DrawSelectedChess(g);
                        return;
                    }
                    else
                    {
                        secondChess2.DrawSelectedChess(g);
                    }
                }
                if (secondChess2 == null) //目标处没棋子，移动棋子
                {
                    if (chessboard.IsAbleToPut(firstChess2, x2, y2))
                    {
                        //******************************************
                        //移动棋子前先生成棋谱信息                 
                        string step_info = chessboard.Create_pu(firstChess2, x2, y2);
                        listBox1.Items.Add(step_info);
                        StepList.Add(step_info);
                        //****************************************** 
                        //在map取掉原CurSelect棋子 
                        idx = chessboard.Map[x1, y1];
                        chessboard.Map[x1, y1] = -1;
                        chessboard.Map[x2, y2] = idx;
                        chessboard.chess[idx].SetPos(x2, y2);
                        //send
                        send("move" + "|" + idx.ToString() + "|" + (10 - x2).ToString() + "|"
                             + Convert.ToString(11 - y2) + "|" + StepList[StepList.Count - 1]);
                        //CurSelect = 0;
                        first = true;
                        chessboard.reDraw();
                        SetMyTurn(false); //该对方了
                        //toolStripStatusLabel1.Text = "";
                    }
                    else
                    {
                        //错误走棋 
                        toolStripStatusLabel1.Text = "不符合走棋规则";
                    }
                    return;
                }
                if (secondChess2 != null && chessboard.IsAbleToPut(firstChess2, x2, y2)) //可以吃子
                {
                    first = true;
                    //******************************************
                    //移动棋子前先生成棋谱信息 
                    string step_info = chessboard.Create_pu(firstChess2, x2, y2);
                    listBox1.Items.Add(step_info);
                    StepList.Add(step_info);
                    //****************************************** 
                    //在map取掉原CurSelect棋子
                    idx = chessboard.Map[x1, y1];
                    idx2 = chessboard.Map[x2, y2];
                    chessboard.Map[x1, y1] = -1;
                    chessboard.Map[x2, y2] = idx;
                    chessboard.chess[idx].SetPos(x2, y2);
                    chessboard.chess[idx2] = null;
                    chessboard.reDraw();
                    if (idx2 == 0) //0---"将"
                    {
                        toolStripStatusLabel1.Text = "红方赢了";
                        MessageBox.Show("红方赢了", "提示");
                        //send
                        send("move" + "|" + idx.ToString() + "|" + (10 - x2).ToString() + "|"
                             + Convert.ToString(11 - y2) + "|" + StepList[StepList.Count - 1]);
                        send("succ" + "|" + "红方赢了");
                        btnNew.Enabled = true; //可以重新开始 
                        return;
                    }
                    if (idx2 == 16) //16--"帅"
                    {
                        toolStripStatusLabel1.Text = "黑方赢了";
                        MessageBox.Show("黑方赢了", "提示");
                        send("move" + "|" + idx.ToString() + "|" + (10 - x2).ToString() + "|"
                             + Convert.ToString(11 - y2) + "|" + StepList[StepList.Count - 1]);
                        send("succ" + "|" + "黑方赢了");
                        btnNew.Enabled = true; //可以重新开始  
                        return;
                    }
                    //send
                    send("move" + "|" + idx.ToString() + "|" + (10 - x2).ToString() + "|"
                         + Convert.ToString(11 - y2) + "|" + StepList[StepList.Count - 1]);
                    SetMyTurn(false); //该对方了 
                    //toolStripStatusLabel1.Text = "";
                }
                else //不能吃子 
                {
                    toolStripStatusLabel1.Text = "不能吃子";
                }
            }
        }

        //设置是否该自己走的提示信息 
        private void SetMyTurn(bool bolIsMyTurn)
        {
            IsMyTurn = bolIsMyTurn;
            if (bolIsMyTurn)
            {
                toolStripStatusLabel1.Text = "请您开始走棋";
            }
            else
            {
                toolStripStatusLabel1.Text = "对方正在思考...";
            }
        }

        //read()方法不断侦听本机设定的端口，得到对方发送来的信息，根据自己定义的通信协议通信中传送的是“输赢信息”，“下的棋子位置信息”，“重新开始”等信息而分别处理。
        private void read()
        {
            //侦听本地的端口号 
            udpclient = new UdpClient(Convert.ToInt32(txt_port.Text));
            //remote = System.DBNull 
            //设定编码类型 
            Encoding enc;
            enc = Encoding.Unicode;
            int idx, x1, x2, y1, y2;
            while (ReadFlag)
            {
                try
                {
                    byte[] data = udpclient.Receive(ref remote);
                    //得到对方发送来的信息 
                    //Encoding.Unicode.GetBytes(Message) 
                    string strData = enc.GetString(data);
                    string[] a = new string[6];
                    a = strData.Split('|');
                    switch (a[0])
                    {
                            //case "join":
                            //    //获取传送信息到本地端口号的远程计算机IP地址 
                            //    string remoteIP = remote.Address.ToString();
                            //    //显示接收信息以及传送信息的计算机IP地址 
                            //    toolStripStatusLabel1.Text = remoteIP + "你是红方请走先棋";
                            //    LocalPlayer = REDPLAYER;
                            //    //显示棋子 
                            //    chessboard.NewGame(LocalPlayer); 
                            //    SetMyTurn(true);//能走棋 
                            //    btnJoin.Enabled = false;
                            //    //发送联机成功信息
                            //    send("begin|");
                            //    break;
                            //case "begin": //联机成功信息 
                            //    //开始新棋局，显示棋子 
                            //    LocalPlayer = BLACKPLAYER;
                            //    chessboard.NewGame(LocalPlayer);
                            //    SetMyTurn(false);
                            //    break;
                        case "join":
                            //显示棋子 
                            chessboard.NewGame(LocalPlayer);
                            if (LocalPlayer == REDPLAYER)
                                SetMyTurn(true); //能走棋
                            else
                                SetMyTurn(false);
                            btnJoin.Enabled = false;
                            //发送联机成功信息
                            send("conn|");
                            break;
                        case "conn": //联机成功信息 
                            //显示棋子 
                            chessboard.NewGame(LocalPlayer);
                            if (LocalPlayer == REDPLAYER)
                                SetMyTurn(true); //能走棋
                            else
                                SetMyTurn(false);
                            btnJoin.Enabled = false;
                            break;
                        case "new": //重新开局
                            toolStripStatusLabel1.Text = "对方重新开局了，请你也重新开局";
                            break;
                        case "lose":
                            MessageBox.Show("恭喜你，对方认输了！", "你赢了");
                            SetMyTurn(false);
                            toolStripStatusLabel1.Text = "你可以重新开局！";
                            btnNew.Enabled = true;
                            break;
                        case "succ":
                            //获取传送信息到本地端口号的远程计算机IP地址 
                            if (a[1] == "黑方赢了")
                            {
                                MessageBox.Show("黑方赢了,你可以重新开始了！", "你输了");
                            }
                            if (a[1] == "红方赢了")
                            {
                                MessageBox.Show("红方赢了,你可以重新开始了！", "你输了");
                            }
                            toolStripStatusLabel1.Text = "你可以重新开局！";
                            btnNew.Enabled = true;
                            break;
                        case "move":
                            //对方的走棋信息,move|棋子索引号|X|Y 
                            idx = Convert.ToInt16(a[1]);
                            x2 = Convert.ToInt16(a[2]);
                            y2 = Convert.ToInt16(a[3]);
                            string z = a[4]; //对方上步走棋的棋谱信息 
                            toolStripStatusLabel1.Text = x2.ToString() + ":" + y2.ToString();

                            //棋谱信息 
                            StepList.Add(z);
                            listBox1.Items.Add(z);

                            Chess c = chessboard.chess[idx];
                            x1 = c.pos.X; //（x1,y1)是移动棋子原处棋盘坐标
                            y1 = c.pos.Y;
                            ;

                            //修改棋子位置,显示对方走棋
                            idx = chessboard.Map[x1, y1];
                            int idx2 = chessboard.Map[x2, y2];
                            chessboard.Map[x1, y1] = -1;
                            chessboard.Map[x2, y2] = idx;
                            chessboard.chess[idx].SetPos(x2, y2);
                            if (idx2 != -1) chessboard.chess[idx2] = null;
                            chessboard.reDraw();
                            SetMyTurn(true);
                            break;
                        case "exit":
                            MessageBox.Show("对方退出了，游戏结束！", "提示");
                            toolStripStatusLabel1.Text = "对方退出了，游戏结束！";
                            ReadFlag = false;
                            break;
                    }
                }
                catch
                {
                    //退出循环，结束线程
                    break;
                }
            }
        }

        //发送信息send(ByVal info As String)较为简单，主要实现创建UDP网络服务，传送信息到指定计算机的txt_remoteport端口号后，关闭UDP网络服务。
        private void send(string info)
        {
            //创建UDP网络服务 
            UdpClient SendUdp = new UdpClient();
            IPAddress remoteIP;
            //判断IP地址的正确性() 
            try
            {
                remoteIP = IPAddress.Parse(txt_IP.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确的IP地址！", "错误");
                return;
            }
            IPEndPoint remoteep = new IPEndPoint(remoteIP, Convert.ToInt32(txt_remoteport.Text));
            byte[] buffer;
            Encoding enc;
            enc = Encoding.Unicode;
            //设定编码类型 
            string str = info;
            buffer = enc.GetBytes(str.ToCharArray());
            //传送信息到指定计算机的txt_remoteport端口号 
            SendUdp.Send(buffer, buffer.Length, remoteep);
            //关闭UDP网络服务() 
            SendUdp.Close();
        }

        private void btnJoin_Click(object sender, EventArgs e) //开始联机
        {
            send("join|");
            // 创建一个线程() 
            th = new Thread(read);
            //启动线程 
            th.Start();
            toolStripStatusLabel1.Text = "程序处于等待联机状态！";
            btnJoin.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e) //重新开始
        {
            if (toolStripStatusLabel1.Text.Trim() != "对方重新开局了，请你也重新开局")
                send("new|");
            if (LocalPlayer == REDPLAYER)
            {
                //游戏者角色改变 
                LocalPlayer = BLACKPLAYER;
                SetMyTurn(false);
            }
            else
            {
                LocalPlayer = REDPLAYER;
                SetMyTurn(true);
            }
            chessboard.NewGame(LocalPlayer);
            btnNew.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //正常棋谱 
            SaveFileDialog DlgFile = new SaveFileDialog();
            //创建一个保存文件对话框实例 
            DlgFile.Filter = "txt files(*.txt)|*.txt";
            DlgFile.RestoreDirectory = true;
            DlgFile.ShowDialog();
            string path = DlgFile.FileName;
            //"棋谱1.txt" 
            StreamWriter Mywriter;
            Mywriter = new StreamWriter(path, false, Encoding.Default);
            //新建覆盖 
            string s = "", m = "";
            Mywriter.WriteLine("棋谱 红方 黑方");
            for (int i = 1; i <= StepList.Count; i++)
            {
                if (i%2 == 1)
                {
                    m = (i/2 + 1).ToString().PadLeft(3, ' ') + ". " + StepList[i - 1];
                }
                if (i%2 == 0 & i != 0)
                {
                    s = m + "  " + StepList[i - 1];
                    Mywriter.WriteLine(s);
                }
            }
            if (StepList.Count%2 == 1) Mywriter.WriteLine(m);
            Mywriter.Close();
        }


        private void btnExit_Click(object sender, EventArgs e) //退出游戏 
        {
            send("exit|");
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            send("exit|");
            ReadFlag = false;
            if (th != null && th.IsAlive)
                th.Abort();
            Application.ExitThread();
            Application.Exit();
        }

        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlack.Checked)
            {
                txt_port.Text = "3003";
                txt_remoteport.Text = "3004";
                LocalPlayer = BLACKPLAYER;
            }
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
            {
                txt_port.Text = "3004";
                txt_remoteport.Text = "3003";
                LocalPlayer = REDPLAYER;
            }
        }

        private void btnFupan_Click(object sender, EventArgs e) //象棋复盘
        {
            Fu_pan frm = new Fu_pan();
            frm.Show();
        }

        private void txt_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLose_Click(object sender, EventArgs e) //认  输
        {
            send("lose|"); //发送认输信息
            btnNew.Enabled = true; //可以重新开始
        }
    }
}