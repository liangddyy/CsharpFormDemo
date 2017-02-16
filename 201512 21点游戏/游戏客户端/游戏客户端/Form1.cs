using SocketClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 游戏客户端
{
    public partial class Form1 : Form
    {
        private bool isContinue = false;
        private bool isOnline = false;

        PictureBox[] ComputerPB = new PictureBox[7];  // 电脑的 PictureBox
        PictureBox[] MyPB = new PictureBox[7];        // 玩家的 PictureBox

        int[] ComputerScore = new int[7]; // 电脑牌的点数     && 点数和  7
        int[] MyScore = new int[7];       // 玩家牌的点数     && 点数和  8

        int ComputerPB_Index = 0; // 电脑的 PictureBox 的索引 进行到第几张
        int MyPB_index = 0;       // 玩家的 PictureBox 的索引 进行到第几张

        bool ComputerPB_Active = true; // 电脑是否持续要牌    && 3
        bool MyPB_Active = true;       // 玩家是否持续要牌    && 4

        bool MyTurn = false; // 玩家时间

        int[] CardSeq = new int[52]; // 纪录 52 张牌序
        // 牌卡的点数
        int[] weight = new int[52] {1,2,3,4,5,6,7,8,9,10,10,10,10,
                                    1,2,3,4,5,6,7,8,9,10,10,10,10,
                                    1,2,3,4,5,6,7,8,9,10,10,10,10,
                                    1,2,3,4,5,6,7,8,9,10,10,10,10};
        Random rd = new Random();
        int Card_No = 0;      // 发牌序 目前发到第几张
        int Card_Washing = 0; // 洗牌序 目前洗牌效果呈现第几张

        //指令是否执行成功,客户端执行服务端的指令  //&& 0
        int isDone = 0;

        //  && 5 && 6 谁爆了
        bool playerDie = false;
        bool ComputerDie = false;

        //  && 9 && 10 谁赢了
        bool playerWin = false;
        bool computerWin = false;

        // 电脑所有牌的总和,玩家除了第一张牌的总和
        int computerSum = 0;
        int playerSum = 0;

        //玩家的ACE数量不包含第一张  1,2
        int computerAces = 0;
        int playerAces = 0;

        string cmd;
        string rCmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int t1, t2, temp;



            ComputerPB[0] = pictureBox3;
            ComputerPB[1] = pictureBox4;
            ComputerPB[2] = pictureBox5;
            ComputerPB[3] = pictureBox6;
            ComputerPB[4] = pictureBox7;
            ComputerPB[5] = pictureBox8;
            ComputerPB[6] = pictureBox9;

            MyPB[0] = pictureBox10;
            MyPB[1] = pictureBox11;
            MyPB[2] = pictureBox12;
            MyPB[3] = pictureBox13;
            MyPB[4] = pictureBox14;
            MyPB[5] = pictureBox15;
            MyPB[6] = pictureBox16;

            for (int i = 0; i <= 51; i++)
            {
                CardSeq[i] = i;
            }

            for (int i = 0; i < 100; i++) // 随机选择两张牌交换，洗牌
            {
                t1 = rd.Next(52);
                t2 = rd.Next(52);
                temp = CardSeq[t1];
                CardSeq[t1] = CardSeq[t2];
                CardSeq[t2] = temp;
            }
        }
        public string toCmd()
        {
            string cmd = isDone.ToString() + ' ' + computerAces.ToString() + ' ' + playerAces.ToString() + ' ' + Convert.ToByte(ComputerPB_Active) + ' ' + Convert.ToByte(MyPB_Active)
                + ' ' + Convert.ToByte(ComputerDie) + ' ' + Convert.ToByte(playerDie) + ' ' + computerSum.ToString()
                + ' ' + playerSum.ToString() + ' ' + Convert.ToByte(computerWin) + ' ' + Convert.ToByte(playerWin);
            return cmd;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 制造洗牌效果
            if (Card_Washing > 48)  // 洗好了 通通翻面
            {
                pictureBox0.Image = Properties.Resources.cardback_blue_lace;
                pictureBox1.Image = Properties.Resources.cardback_blue_lace;
                pictureBox2.Image = Properties.Resources.cardback_blue_lace;
                timer1.Enabled = false;
                timer2.Enabled = true;  // 让电脑叫牌
                toolStripStatusLabel1.Text = "电脑叫牌";
            }
            else  // 制造洗牌效果
            {
                pictureBox0.Image = imageList1.Images[CardSeq[Card_Washing++]];
                pictureBox1.Image = imageList1.Images[CardSeq[Card_Washing++]];
                pictureBox2.Image = imageList1.Images[CardSeq[Card_Washing++]];
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer2.Enabled = false;
            // 电脑跑一张 到位了
            if (ComputerPB[ComputerPB_Index].Location.X - pictureBox2.Location.X < 10)
            {
                timer2.Enabled = false; // 电脑一次只跑一张
                ComputerScore[ComputerPB_Index] = CardSeq[Card_No];
                // 将目标牌 秀出
                if (ComputerPB_Index == 0) // 电脑第一张不翻牌
                {
                    ComputerPB[ComputerPB_Index].Image = Properties.Resources.cardback_blue_lace;
                    Card_No++; // 发牌序 加一
                }
                else
                {
                    ComputerPB[ComputerPB_Index].Image = imageList1.Images[CardSeq[Card_No]];
                    Card_No++; // 发牌序 加一
                }
                pictureBox2.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y - 10);  // 瞬間將發牌 移回 原處 障眼法

                // 要决定 是否 电脑要叫停
                int sum = 0;
                int aces = 0;
                for (int i = 0; i <= ComputerPB_Index; i++)
                {
                    sum = sum + weight[ComputerScore[i]]; // 全部加总 Ace 算 1 分
                    if (weight[ComputerScore[i]] == 1) aces++; // 有几张 Ace
                }
                computerSum = sum;  //电脑总数(包含第一张)所有Ace算1分
                computerAces = aces;

                rCmd = TcpPost.Start(toCmd(), txtAdress.Text.ToString(), txtPort.Text.ToString());
                //MessageBox.Show(rCmd);
                /*
                if(!rCmd.Contains("无法连接"))
                    if (Convert.ToInt32(rCmd) == 0)
                    {
                        ComputerPB_Active = false;
                    }
                    */
                /*
                if (sum > 16) ComputerPB_Active = false; // 电脑 不再 要牌    
                else if (aces >= 1 && sum > 7) ComputerPB_Active = false;
                else if (aces >= 2 && sum == 3) ComputerPB_Active = false;
                */

                if (sum > 21)
                {
                    ComputerDie = true;
                    isContinue = false;
                    timer_state.Enabled = true;
                    return;
                }

                if (MyPB_Active) // 如果玩家 還未 叫停 
                    MyTurn = true; // 開始 玩家時間 
                else if (ComputerPB_Active) // 否則  玩家已經叫停 且 电脑 尚未叫停
                {
                    if (ComputerPB_Index < ComputerPB.Length - 1) // 还有空间
                    {
                        ComputerPB_Index++;
                        timer2.Enabled = true;  // 电脑再跑一張
                    }
                }

                if (timer2.Enabled)
                    toolStripStatusLabel1.Text = "电脑叫牌";
                else
                {
                    if (ComputerPB_Active)
                        toolStripStatusLabel1.Text = "等玩家";
                    else
                        toolStripStatusLabel1.Text = "电脑叫停,等玩家";
                }
            }
            else // 持續移動
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Start("连接成功");
        }
        private void Start(string cmd)
        {
            bool checkResult = CheckMessage(cmd);


            if (checkResult)
            {

                //string cmd = cmbCommand.Text;

                //txtShowInfo.Text += TcpPost.Start(cmd, txtAdress.Text, txtPort.Text) + Environment.NewLine;
                rCmd = TcpPost.Start(cmd, txtAdress.Text, txtPort.Text);
            }


            //表示已经连接上
            if (!rCmd.Contains("无法连接"))
            {
                isContinue = true;
                isOnline = true;
                timer_state.Enabled = true;

                MessageBox.Show("连接成功,祝您游戏愉快!");
            }
            else
            {
                isOnline = false;
                MessageBox.Show("未找到服务端!");
            }

        }
        private bool CheckMessage(string cmd)
        {
            bool boolresult = true;
            if (!IPCheck(txtAdress.Text))
            {
                boolresult = false;
                lblShowText.Text = "IP地址为空或者格式不正确";
            }
            if (string.IsNullOrEmpty(txtPort.Text) || !CheckInt(txtPort.Text))
            {
                boolresult = false;
                lblShowText.Text = "端口为空或者格式不正确";
            }
            if (string.IsNullOrEmpty(cmd))
            {
                boolresult = false;
                lblShowText.Text = "发送信息为空";
            }

            return boolresult;
        }
        private bool IPCheck(string ip)
        {

            string num = "(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)";

            return Regex.IsMatch(ip, ("^" + num + "\\." + num + "\\." + num + "\\." + num + "$"));
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

        private void button1_Click(object sender, EventArgs e)
        {
            clearValue();
            isContinue = true;
            timer_state.Enabled = true;

            int t1, t2, temp;

            for (int i = 0; i < ComputerPB.Length; i++)
                ComputerPB[i].Image = null;  // 电脑的 PictureBox

            for (int i = 0; i < MyPB.Length; i++)
                MyPB[i].Image = null;         // 玩家的 PictureBox

            for (int i = 0; i <= 51; i++)  // 先依序排好
                CardSeq[i] = i;

            //洗牌
            for (int i = 0; i < 100; i++)  // 再兩兩洗牌 
            {
                t1 = rd.Next(52);
                t2 = rd.Next(52);
                temp = CardSeq[t1];
                CardSeq[t1] = CardSeq[t2];
                CardSeq[t2] = temp;
            }

            ComputerPB_Index = 0; // 电脑的 PictureBox 的索引
            MyPB_index = 0;       // 玩家的 PictureBox 的索引

            ComputerPB_Active = true; // 电脑是否持續要牌 
            MyPB_Active = true;       // 玩家是否持續要牌

            toolStripStatusLabel1.Text = "洗牌";
            toolStripStatusLabel2.Text = "";

            MyTurn = false; // 玩家時間

            Card_No = 0;  // 發牌序 從頭開始

            Card_Washing = 0;  // 洗牌序 只是為了呈現效果

            timer1.Enabled = true;
        }
        private void clearValue()
        {
            computerAces = 0;
            playerAces = 0;
            ComputerPB_Active = true;
            MyPB_Active = true;
            ComputerDie = false;
            playerDie = false;
            computerSum = 0;
            playerSum = 0;
            computerWin = false;
            playerWin = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MyTurn)
            {
                pictureBox2.Location = new Point(MyPB[MyPB_index].Location.X, MyPB[MyPB_index].Location.Y);
                pictureBox1.Refresh();
                Thread.Sleep(400);

                MyScore[MyPB_index] = CardSeq[Card_No];
                MyPB[MyPB_index].Image = imageList1.Images[CardSeq[Card_No++]];
                pictureBox2.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y - 10);

                // 決定 是否 玩家暴掉了
                int sum = 0;
                int aces = 0;
                for (int i = 0; i <= MyPB_index; i++)
                {
                    sum = sum + weight[MyScore[i]];
                    if (weight[MyScore[i]] == 1) aces++; // 有几张 Ace
                }
                if (weight[MyScore[0]] == 1)
                    playerAces = aces - 1;
                else
                    playerAces = aces;

                playerSum = sum - weight[MyScore[0]];

                if (sum > 21)
                {
                    MyPB_index++;
                    //玩家爆掉
                    playerDie = true;
                    //游戏终止
                    isContinue = false;
                    //调用状态判定
                    timer_state.Enabled = true;
                    return;
                }

                if (MyPB_Active) // 如果玩家 還未 叫停
                {
                    if (MyPB_index < MyPB.Length - 1) MyPB_index++;
                }

                if (ComputerPB_Active)  // 如果 电脑 尚未 叫停
                {
                    MyTurn = false; // 电脑時間
                    if (ComputerPB_Index < ComputerPB.Length - 1) // 還有空間
                    {
                        ComputerPB_Index++;
                        timer2.Enabled = true;  // 讓电脑叫牌
                        toolStripStatusLabel1.Text = "电脑叫牌";
                    }
                }
                else if (MyPB_Active) // 电脑 已經叫停  玩家 還未 叫停
                    MyTurn = true; // 開始 玩家時間
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MyTurn)
            {
                MyPB_Active = false;
                toolStripStatusLabel2.Text = "玩家叫停";

                if (MyTurn == true) // 玩家時間
                {
                    if (ComputerPB_Active) // 玩家已經叫停 且 电脑 尚未叫停
                    {
                        if (ComputerPB_Index < ComputerPB.Length - 1) // 還有空間
                        {
                            ComputerPB_Index++;
                            timer2.Enabled = true;  // 讓电脑叫牌
                            toolStripStatusLabel1.Text = "电脑叫牌";
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum1 = 0;
            int aces1 = 0;
            int k;

            int sum2 = 0;
            int aces2 = 0;

            if (ComputerPB_Active == false) // 如果电脑已經叫停 
            {
                //暂时终止游戏
                isContinue = false;
                timer_state.Enabled = true;

                ComputerPB[0].Image = imageList1.Images[CardSeq[0]]; // 电脑第一張翻牌

                // 計算 电脑的最高得分
                for (int i = 0; i <= ComputerPB_Index; i++)
                {
                    sum1 = sum1 + weight[ComputerScore[i]];
                    if (weight[ComputerScore[i]] == 1) aces1++; // 电脑有幾張 Ace 
                }
                if (aces1 >= 1)
                {
                    k = sum1 + 9;
                    if (k <= 21) sum1 = k;
                }
                if (aces1 >= 2)  // 最多只會有2張Ace當作10 否則會爆掉
                {
                    k = sum1 + 9;
                    if (k <= 21) sum1 = k;
                }

                // 計算 玩家的最高得分
                for (int i = 0; i < MyPB_index; i++)
                {
                    sum2 = sum2 + weight[MyScore[i]];
                    if (weight[MyScore[i]] == 1) aces2++; // 玩家有幾張 Ace
                }
                if (aces2 >= 1)
                {
                    k = sum2 + 9;
                    if (k <= 21) sum2 = k;
                }
                if (aces2 >= 2)
                {
                    k = sum2 + 9;
                    if (k <= 21) sum2 = k;
                }

                string msgStr = " ";
                if (sum1 > 21)
                    msgStr = "电脑爆了！ 玩家贏！" + Convert.ToString(sum1) + " : " + Convert.ToString(sum2);
                else if (sum2 > 21)
                    msgStr = "玩家爆了！ 电脑贏！" + Convert.ToString(sum1) + " : " + Convert.ToString(sum2);
                else if (sum1 > sum2)
                    msgStr = "电脑贏！" + Convert.ToString(sum1) + " : " + Convert.ToString(sum2);
                else if (sum1 < sum2)
                    msgStr = "玩家贏！" + Convert.ToString(sum1) + " : " + Convert.ToString(sum2);
                else if (sum1 == sum2)
                    msgStr = "平手" + Convert.ToString(sum1) + " : " + Convert.ToString(sum2);

                MessageBox.Show(msgStr);
                lblShowText.Text = " 上一局战况: " + msgStr;
            }
        }

        private void timer_state_Tick(object sender, EventArgs e)
        {
            timer_state.Enabled = false;
            if (!isContinue)
            {
                //相关按键全部不可用。游戏暂时终止
                //button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                ComputerPB_Active = false;
                MyPB_Active = false;
            }
            else
            {
                //button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                ComputerPB_Active = true;
                MyPB_Active = true;
            }

            if (playerDie)
            {
                if (!ComputerDie)
                {
                    playerWin = true;
                    MessageBox.Show("玩家爆了！ 电脑贏！");
                }

            }
            if (ComputerDie)
            {
                if (!playerDie)
                {
                    computerWin = true;
                    MessageBox.Show("电脑爆了！ 玩家赢！");
                }

            }
            if (isOnline)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
