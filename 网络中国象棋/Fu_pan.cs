using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 网络象棋
{
    public partial class Fu_pan : Form
    {
        public const short REDPLAYER = 1;
        public const short BLACKPLAYER = 0;
        private readonly ArrayList step_info = new ArrayList();
        //CurSelect表示当前选中的棋子,LocalPlayer记录自己是红是黑 
        private int CurSelect = -1;
        public short LocalPlayer;
        private StreamReader Myread;
        private int Step_Num; //步数
        private ChessBoard chessboard;
        private string pathfile; //复盘打开的文件名
        private string s; //每步走棋信息

        public Fu_pan()
        {
            InitializeComponent();
            //不捕获线程控件调用异常
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Fu_pan_Load(object sender, EventArgs e) //Load事件
        {
            chessboard = new ChessBoard();
            chessboard.winHandle = picBoard.Handle;
            picBoard.BackgroundImage = new Bitmap(360, 400);
            chessboard.bufferImage = picBoard.BackgroundImage;
            chessboard.reDraw();
        }

        //移动索引号为idx棋子到(x2, y2)处
        private void MoveChess(int idx, int x2, int y2)
        {
            int x1, y1;
            Chess c = chessboard.chess[idx];
            x1 = c.pos.X; //（x1,y1)是移动棋子原处棋盘坐标
            y1 = c.pos.Y;

            //修改棋子位置,显示走棋
            idx = chessboard.Map[x1, y1];
            int idx2 = chessboard.Map[x2, y2];
            chessboard.Map[x1, y1] = -1;
            chessboard.Map[x2, y2] = idx;
            chessboard.chess[idx].SetPos(x2, y2);
            if (idx2 != -1) chessboard.chess[idx2] = null;
            chessboard.reDraw();

            //No_chessPic.Left = (x1-1) * 40;
            //No_chessPic.Top = (y1-1) * 40;
            //No_chessPic.Parent = this.picBoard; 
            ////画棋子移动原位置的示意边框线
            Graphics g = picBoard.CreateGraphics();
            Pen myPen = new Pen(Color.Blue, 3);
            Rectangle r = new Rectangle(x1*40 - 40, y1*40 - 40, 40, 40);
            g.DrawRectangle(myPen, r);
        }

        private void button1_Click(object sender, EventArgs e) //选择棋谱
        {
            listBox1.Items.Clear();
            Step_Num = 0;
            step_info.Clear();
            OpenFileDialog DlgOpenFile = new OpenFileDialog();
            //创建一个打开文件对话框实例 
            DlgOpenFile.Filter = "txt files(*.txt)|*.txt";
            DlgOpenFile.RestoreDirectory = true;
            DlgOpenFile.ShowDialog();
            pathfile = DlgOpenFile.FileName;
            if (pathfile == "") return;
            //"棋谱1.txt" 
            Myread = new StreamReader(pathfile, Encoding.Default);
            s = Myread.ReadLine(); //读取首行---棋谱 红方 黑方 
            s = Myread.ReadLine(); //读取第一步 

            //棋谱格式("前三位数字,第四位点号,第5位空格,第6--9位红方走棋信息,") 
            //棋谱格式("第10,11位空格,第12--15位黑方走棋信息,") 
            while ((s != null))
            {
                s = s.Substring(5, s.Length - 5);
                step_info.Add(s.Substring(0, 4)); //红方走棋信息 

                if (s.Length - 6 < 4) break; //仅有红棋,无黑棋信息 
                s = s.Substring(6, s.Length - 6);
                step_info.Add(s.Substring(0, 4)); //黑方走棋信息 
                s = Myread.ReadLine();
            }
            Myread.Close();
            LocalPlayer = REDPLAYER;
            chessboard.NewGame(LocalPlayer);
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private bool IsMyChess(int idx)
        {
            bool functionReturnValue = false;
            //象棋索引号0－－１5黑方，16－－31红方
            if (idx >= 0 && idx < 16 && LocalPlayer == BLACKPLAYER)
                functionReturnValue = true;
            if (idx >= 16 && idx < 32 && LocalPlayer == REDPLAYER)
                functionReturnValue = true;
            return functionReturnValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //单步复盘 
            string s, chess_p, GoDirect, c;
            int a, b, x1 = 0, y1 = 0, x2, y2, dx = 0, dy = 0, idx = 0;
            c = "";
            if (Step_Num < step_info.Count) //步数没有演示结束
            {
                No_chessPic.Visible = true;
                if (CurSelect != -1)
                {
                    //CurSelect是上次移动棋子的ID 
                    chessboard.chess[CurSelect].UnDrawSelectedChess(
                        picBoard.CreateGraphics(), Color.White);
                }
                if (LocalPlayer == REDPLAYER) //现在是红方走棋
                {
                    s = step_info[Step_Num].ToString(); //红方此步棋谱 
                    chess_p = s.Substring(0, 1); //红方此步棋谱第一个字
                    if (chess_p == "前" | chess_p == "后") //在垂直方向有相同子
                    {
                        c = chess_p; //c存放"前" Or "后" 
                        //得到此步棋谱第2个字，如前车的车
                        chess_p = s.Substring(1, 1);
                        //处理"前" Or "后"时坐标（x1,y1）                        
                        Findxy(c, chess_p, ref idx, ref x1, ref y1);
                        a = 10 - x1;
                    }
                    else
                    {
                        a = ConvertNum(s.Substring(1, 1));
                        //得到车二的2 
                    }
                    GoDirect = s.Substring(2, 1);
                    b = ConvertNum(s.Substring(3, 1));
                    listBox1.Items.Add("红" + Convert.ToString(Step_Num/2 + 1)
                                       + ". " + s.Substring(0, 4));
                    //原始位置坐标(x1,y1),目的坐标(x2,y2)
                    switch (GoDirect)
                    {
                        case "平":
                            //如果是平,x坐标变化 
                            x1 = 10 - a;
                            x2 = 10 - b;
                            if (c == "前" | c == "后")
                            {
                                //在垂直方向有相同子 
                                y2 = y1;
                            }
                            else
                            {
                                y2 = Findy(x1, chess_p, ref idx);
                            }
                            MoveChess(idx, x2, y2);
                            break;
                        case "进":
                            //红方进 
                            if (chess_p == "兵" | chess_p == "炮" | chess_p == "车" | chess_p == "帅")
                            {
                                //如果是直线进，y坐标变化 炮八进二 
                                x1 = 10 - a;
                                x2 = x1;
                                dy = b;
                                if (c == "前" | c == "后")
                                {
                                    //在垂直方向有相同子 
                                    y2 = y1 - dy;
                                }
                                else
                                {
                                    y2 = Findy(x1, chess_p, ref idx) - dy;
                                }
                                MoveChess(idx, x2, y2);
                            }
                            if (chess_p == "马" | chess_p == "相" | chess_p == "仕")
                            {
                                //如果是斜线进，x,y坐标同时变化 马二进三 
                                x1 = 10 - a;
                                x2 = 10 - b;
                                dx = Math.Abs(b - a);
                                if (chess_p == "马")
                                {
                                    if (dx == 1) dy = 2;
                                    if (dx == 2) dy = 1;
                                }
                                if (chess_p == "相") dy = dx;
                                if (chess_p == "仕") dy = dx;
                                if (c == "前" | c == "后")
                                {
                                    //在垂直方向有相同子 
                                    y2 = y1 - dy;
                                }
                                else
                                {
                                    y2 = Findy(x1, chess_p, ref idx) - dy;
                                }
                                MoveChess(idx, x2, y2);
                            }

                            break;
                        case "退":
                            //红方退 
                            if (chess_p == "兵" | chess_p == "炮" | chess_p == "车" | chess_p == "帅")
                            {
                                //如果是直线进，y坐标变化 炮八退二 
                                x1 = 10 - a;
                                x2 = x1;
                                dy = b;
                                if (c == "前" | c == "后")
                                {
                                    //在垂直方向有相同子 
                                    y2 = y1 + dy;
                                }
                                else
                                {
                                    y2 = Findy(x1, chess_p, ref idx) + dy;
                                }
                                MoveChess(idx, x2, y2);
                            }
                            if (chess_p == "马" | chess_p == "相" | chess_p == "仕")
                            {
                                //如果是斜线进，x,y坐标同时变化 马三退一 
                                x1 = 10 - a;
                                x2 = 10 - b;
                                dx = Math.Abs(b - a);
                                if (chess_p == "马")
                                {
                                    if (dx == 1)
                                        dy = 2;
                                    if (dx == 2)
                                        dy = 1;
                                }
                                if (chess_p == "相") dy = dx;
                                if (chess_p == "仕") dy = dx;
                                if (c == "前" | c == "后")
                                {
                                    //在垂直方向有相同子 
                                    y2 = y1 + dy;
                                }
                                else
                                {
                                    y2 = Findy(x1, chess_p, ref idx) + dy;
                                }
                                MoveChess(idx, x2, y2);
                            }
                            break;
                    }
                }
                else
                {
                    //************************黑方************************************** 
                    //黑方 
                    s = step_info[Step_Num].ToString();
                    chess_p = s.Substring(0, 1);
                    c = "";
                    if (chess_p == "前" | chess_p == "后")
                    {
                        //在垂直方向有相同子 
                        c = (chess_p == "前" ? "后" : "前");
                        //c存放"前" Or "后" 
                        chess_p = s.Substring(1, 1);
                        //得到前车的车 
                        Findxy(c, chess_p, ref idx, ref x1, ref y1);
                        //处理"前" Or "后"时x1,y1 
                        a = 10 - x1;
                    }
                    else
                    {
                        a = ConvertNum(s.Substring(1, 1));
                        //得到车2的2 
                    }
                    GoDirect = s.Substring(2, 1);
                    b = ConvertNum(s.Substring(3, 1));
                    listBox1.Items.Add("黑" + Convert.ToString(Step_Num/2 + 1)
                                       + ". " + s.Substring(0, 4));
                    switch (GoDirect)
                    {
                        case "平":
                            //如果是平,x坐标变化 
                            x1 = a;
                            x2 = b;
                            if (c == "前" | c == "后")
                            {
                                //在垂直方向有相同子 
                                y2 = y1;
                            }
                            else
                            {
                                y2 = Findy(x1, chess_p, ref idx);
                            }
                            MoveChess(idx, x2, y2);
                            break;
                        case "进":
                            //**********黑方进 
                            if (chess_p == "卒" | chess_p == "炮" | chess_p == "车" | chess_p == "将")
                            {
                                //如果是直线进，y坐标变化 炮8进2 
                                x1 = a;
                                x2 = x1;
                                dy = b;
                                if (c == "前" | c == "后")
                                {
                                    //在垂直方向有相同子 
                                    y2 = y1 + dy;
                                }
                                else
                                {
                                    y2 = Findy(x1, chess_p, ref idx) + dy;
                                }
                                MoveChess(idx, x2, y2);
                            }

                            if (chess_p == "马" | chess_p == "象" | chess_p == "士")
                            {
                                //如果是斜线进，x,y坐标同时变化 马2进3 
                                x1 = a;
                                x2 = b;
                                dx = Math.Abs(b - a);
                                if (chess_p == "马")
                                {
                                    if (dx == 1)
                                        dy = 2;
                                    if (dx == 2)
                                        dy = 1;
                                }
                                if (chess_p == "象")
                                    dy = dx;
                                if (chess_p == "士")
                                    dy = dx;
                                if (c == "前" | c == "后")
                                {
                                    //在垂直方向有相同子 
                                    y2 = y1 + dy;
                                }
                                else
                                {
                                    y2 = Findy(x1, chess_p, ref idx) + dy;
                                }
                                MoveChess(idx, x2, y2);
                            }

                            break;
                        case "退":
                            //**********黑方退 
                            if (chess_p == "卒" | chess_p == "炮" | chess_p == "车" | chess_p == "将")
                            {
                                //如果是直线进，y坐标变化 炮8退2 
                                x1 = a;
                                x2 = x1;
                                dy = b;
                                if (c == "前" | c == "后")
                                {
                                    //在垂直方向有相同子 
                                    y2 = y1 - dy;
                                }
                                else
                                {
                                    y2 = Findy(x1, chess_p, ref idx) - dy;
                                }
                                MoveChess(idx, x2, y2);
                            }
                            if (chess_p == "马" | chess_p == "象" | chess_p == "士")
                            {
                                //如果是斜线进，x,y坐标同时变化 马3退1 
                                x1 = a;
                                x2 = b;
                                dx = Math.Abs(b - a);
                                if (chess_p == "马")
                                {
                                    if (dx == 1)
                                        dy = 2;
                                    if (dx == 2)
                                        dy = 1;
                                }
                                if (chess_p == "象")
                                    dy = dx;
                                if (chess_p == "士")
                                    dy = dx;
                                if (c == "前" | c == "后")
                                {
                                    //在垂直方向有相同子 
                                    y2 = y1 - dy;
                                }
                                else
                                {
                                    y2 = Findy(x1, chess_p, ref idx) - dy;
                                }
                                MoveChess(idx, x2, y2);
                            }
                            break;
                    }
                }
                Step_Num = Step_Num + 1;
                //My.Computer.Audio.Play("move.wav");
                //换成对方 
                if (LocalPlayer == REDPLAYER)
                {
                    LocalPlayer = BLACKPLAYER;
                }
                else
                {
                    LocalPlayer = REDPLAYER;
                }
                //******************************************************* 
                CurSelect = idx; //当前移动棋子的ID                
                Graphics g = picBoard.CreateGraphics();
                chessboard.chess[CurSelect].DrawSelectedChess(g);
            }
            else
            {
                MessageBox.Show("结束了!!!!!!", "提示");
            }
        }

        private int ConvertNum(string s)
        {
            switch (s)
            {
                case "一":
                case "1":
                    return 1;
                case "二":
                case "2":
                    return 2;
                case "三":
                case "3":
                    return 3;
                case "四":
                case "4":
                    return 4;
                case "五":
                case "5":
                    return 5;
                case "六":
                case "6":
                    return 6;
                case "七":
                case "7":
                    return 7;
                case "八":
                case "8":
                    return 8;
                case "九":
                case "9":
                    return 9;
                default:
                    return 0;
            }
        }

        //根据棋子类型名Qi_zi获取原始位置坐标(x1,y1)及棋子的索引号idx
        private void Findxy(string c, string Qi_zi, ref int idx, ref int x1, ref int y1)
        {
            int x, y;
            if (c == "前")
            {
                for (x = 1; x <= 9; x++)
                {
                    for (y = 1; y <= 10; y++)
                    {
                        idx = chessboard.Map[x, y]; //idx象棋索引号
                        //无棋子或不是自己方棋子 
                        if (idx == -1 || !IsMyChess(idx))
                            continue;
                        else
                        {
                            if (chessboard.chess[idx].typeName == Qi_zi)
                            {
                                x1 = x;
                                y1 = y;
                                return;
                                //Exit For错误 
                            }
                        }
                    }
                }
            }
            if (c == "后")
            {
                for (x = 1; x <= 9; x++)
                {
                    for (y = 10; y >= 1; y += -1)
                    {
                        idx = chessboard.Map[x, y]; //idx象棋索引号
                        //无棋子或不是自己方棋子
                        if (idx == -1 | !IsMyChess(idx))
                            continue;
                        else
                        {
                            if (chessboard.chess[idx].typeName == Qi_zi)
                            {
                                x1 = x;
                                y1 = y;
                                return;
                            }
                        }
                    }
                }
            }
        }

        //在指定x坐标基础上，获取指定棋子类型名Qi_zi的索引号idx及y坐标
        private int Findy(int x1, string Qi_zi, ref int idx)
        {
            for (int y = 1; y <= 10; y++)
            {
                idx = chessboard.Map[x1, y]; //idx象棋索引号
                //无棋子或不是自己方棋子
                if (idx == -1 || !IsMyChess(idx))
                    continue;
                else
                {
                    if (chessboard.chess[idx].typeName == Qi_zi)
                    {
                        return y;
                    }
                }
            }
            idx = -1;
            return -1; //没找到！
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = 0;
            button3.Enabled = false;
            while (n <= step_info.Count)
            {
                button2_Click(sender, e); //调用单步复盘
                Thread.Sleep(1000); //延时1秒等1000ms 
                n++;
            }
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}