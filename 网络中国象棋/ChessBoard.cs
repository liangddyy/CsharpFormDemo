using System;
using System.Drawing;

namespace 网络象棋
{
    internal class ChessBoard //棋盘类 
    {
        public const short REDPLAYER = 1;
        public const short BLACKPLAYER = 0;
        private readonly int r; //r是棋子半径
        public int[,] Map = new int[9 + 1,10 + 1]; //所有棋子
        public Image bufferImage; //双缓存
        public Chess[] chess = new Chess[32]; //所有棋子
        public IntPtr winHandle; //游戏面板句柄

        public ChessBoard()
        {
            r = 20;
            cls_map();
        }

        private void cls_map()
        {
            int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Map[i, j] = -1;
                }
            }
        }

        public void DrawBoard(Graphics g) //绘制棋盘
        {
            int i;
            //使用GetGraphicsObject函数获取将用于绘图的图形对象的引用 
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 1;
            for (i = 0; i <= 8; i++) //竖线
            {
                if (i == 0 || i == 8) myPen.Width = 2;
                else myPen.Width = 1;
                g.DrawLine(myPen, r + i*2*r, r, r + i*2*r, r*2*10 - r + 1);
            }
            for (i = 0; i <= 9; i++) //横线 
            {
                if (i == 0 || i == 9) myPen.Width = 2;
                else myPen.Width = 1;
                g.DrawLine(myPen, r, r + i*2*r, r*2*9 - r, r + i*2*r);
            }
            Rectangle rectangle = new Rectangle(r + 1, r + r*8 + 1, r*9*2 - 2*r - 2, 2*r - 2);
            SolidBrush brush1 = new SolidBrush(Color.Brown);
            g.DrawEllipse(Pens.Black, rectangle);
            g.DrawRectangle(Pens.Blue, rectangle);
            g.FillRectangle(brush1, rectangle);
            Font font1 = new Font("Arial", 20);
            SolidBrush brush2 = new SolidBrush(Color.Yellow);
            g.DrawString("      楚 河        汉 界    ", font1, brush2, (r + 1), (r + r*8 + 1));
            //画九宫斜线 
            g.DrawLine(myPen, r + r*6 + 1, r + 1, r + r*6 + r*4 - 1, r + r*4 - 1);
            g.DrawLine(myPen, r + r*6 + 1, r + r*4 - 1, r + r*6 + r*4 - 1, r + 1);
            g.DrawLine(myPen, r + r*6 + 1, r*14 + r + 1, r + r*6 + r*4 - 1, r*14 + r + r*4 - 1);
            g.DrawLine(myPen, r + r*6 + 1, r*14 + r + r*4 - 1, r + r*6 + r*4 - 1, r*14 + r + 1);
        }

        public void NewGame(short player) //棋子初始布局
        {
            cls_map(); //清空存储棋子信息数组
            InitChess();
            if (player == BLACKPLAYER) ReverseBoard();
            reDraw();
        }

        private void InitChess()
        {
            //布置黑方棋子
            chess[0] = new Chess(BLACKPLAYER, "将", new Point(5, 1));
            Map[5, 1] = 0;
            chess[1] = new Chess(BLACKPLAYER, "士", new Point(4, 1));
            Map[4, 1] = 1;
            chess[2] = new Chess(BLACKPLAYER, "士", new Point(6, 1));
            Map[6, 1] = 2;
            chess[3] = new Chess(BLACKPLAYER, "象", new Point(3, 1));
            Map[3, 1] = 3;
            chess[4] = new Chess(BLACKPLAYER, "象", new Point(7, 1));
            Map[7, 1] = 4;
            chess[5] = new Chess(BLACKPLAYER, "马", new Point(2, 1));
            Map[2, 1] = 5;
            chess[6] = new Chess(BLACKPLAYER, "马", new Point(8, 1));
            Map[8, 1] = 6;

            chess[7] = new Chess(BLACKPLAYER, "车", new Point(1, 1));
            Map[1, 1] = 7;
            chess[8] = new Chess(BLACKPLAYER, "车", new Point(9, 1));
            Map[9, 1] = 8;

            chess[9] = new Chess(BLACKPLAYER, "炮", new Point(2, 3));
            Map[2, 3] = 9;
            chess[10] = new Chess(BLACKPLAYER, "炮", new Point(8, 3));
            Map[8, 3] = 10;

            for (int i = 0; i <= 4; i++)
            {
                chess[11 + i] = new Chess(BLACKPLAYER, "卒", new Point(1 + i*2, 4));
                Map[1 + i*2, 4] = 11 + i;
            }

            //布置红方棋子
            chess[16] = new Chess(REDPLAYER, "帅", new Point(5, 10));
            Map[5, 10] = 16;
            chess[17] = new Chess(REDPLAYER, "仕", new Point(4, 10));
            Map[4, 10] = 17;
            chess[18] = new Chess(REDPLAYER, "仕", new Point(6, 10));
            Map[6, 10] = 18;
            chess[19] = new Chess(REDPLAYER, "相", new Point(3, 10));
            Map[3, 10] = 19;
            chess[20] = new Chess(REDPLAYER, "相", new Point(7, 10));
            Map[7, 10] = 20;
            chess[21] = new Chess(REDPLAYER, "马", new Point(2, 10));
            Map[2, 10] = 21;
            chess[22] = new Chess(REDPLAYER, "马", new Point(8, 10));
            Map[8, 10] = 22;

            chess[23] = new Chess(REDPLAYER, "车", new Point(1, 10));
            Map[1, 10] = 23;
            chess[24] = new Chess(REDPLAYER, "车", new Point(9, 10));
            Map[9, 10] = 24;

            chess[25] = new Chess(REDPLAYER, "炮", new Point(2, 8));
            Map[2, 8] = 25;
            chess[26] = new Chess(REDPLAYER, "炮", new Point(8, 8));
            Map[8, 8] = 26;

            for (int i = 0; i <= 4; i++)
            {
                chess[27 + i] = new Chess(REDPLAYER, "兵", new Point(1 + i*2, 7));
                Map[1 + i*2, 7] = 27 + i;
            }
        }

        /*重画场景中所有对象*/

        public void reDraw()
        {
            //重画背景
            Graphics g = Graphics.FromImage(bufferImage);
            //Bitmap bg = 网络象棋.Properties.Resources.棋盘;
            //g.DrawImage(bg, 0, 0, 500, 500);
            g.Clear(Color.White);
            DrawBoard(g); //绘制棋盘
            //画棋子
            for (int i = 0; i < 32; i++)
                if (chess[i] != null)
                    chess[i].Draw(bufferImage);
            //缓存输出
            Graphics g2 = Graphics.FromHwnd(winHandle);
            g2.DrawImage(bufferImage, 0, 0, 360, 400);
        }

        private void ReverseBoard() //翻转棋子
        {
            int x, y, c;
            //对调(x,y)与(10-x,11-y)处棋子
            for (int i = 0; i < 32; i++)
                if (chess[i] != null)
                {
                    chess[i].ReversePos();
                }
            //对调Map记录的棋子索引号
            for (x = 1; x <= 9; x++)
            {
                for (y = 1; y <= 5; y++)
                {
                    if (Map[x, y] != -1)
                    {
                        c = Map[10 - x, 11 - y];
                        Map[10 - x, 11 - y] = Map[x, y];
                        Map[x, y] = c;
                    }
                }
            }
        }

        //IsAbleToPut(idx, x, y)实现判断是否能走棋返回逻辑值，这代码最复杂。
        public bool IsAbleToPut(Chess firstchess, int x, int y)
        {
            int i, j, c;
            int oldx, oldy; //在棋盘原坐标          
            oldx = firstchess.pos.X;
            oldy = firstchess.pos.Y;
            string qi_name = firstchess.typeName;
            if (qi_name == "将" || qi_name == "帅")
            {
                if ((x - oldx)*(y - oldy) != 0)
                    return false;
                if (Math.Abs(x - oldx) > 1 || Math.Abs(y - oldy) > 1)
                    return false;
                if (x < 4 || x > 6 || (y > 3 && y < 8))
                    return false;
                return true;
            }
            if (qi_name == "士" || qi_name == "仕")
            {
                if ((x - oldx)*(y - oldy) == 0) return false;
                if (Math.Abs(x - oldx) > 1 || Math.Abs(y - oldy) > 1)
                    return false;
                if (x < 4 || x > 6 || (y > 3 && y < 8)) return false;
                return true;
            }

            if (qi_name == "象" || qi_name == "相")
            {
                if ((x - oldx)*(y - oldy) == 0) return false;
                if (Math.Abs(x - oldx) != 2 || Math.Abs(y - oldy) != 2)
                    return false;
                if (y < 6) return false;
                i = 0;
                j = 0; //i,j必须有初始值
                if (x - oldx == 2)
                {
                    i = x - 1;
                }
                if (x - oldx == -2)
                {
                    i = x + 1;
                }
                if (y - oldy == 2)
                {
                    j = y - 1;
                }
                if (y - oldy == -2)
                {
                    j = y + 1;
                }
                if (Map[i, j] != -1) return false;
                return true;
            }
            if (qi_name == "马" || qi_name == "马")
            {
                if (Math.Abs(x - oldx)*Math.Abs(y - oldy) != 2)
                    return false;
                if (x - oldx == 2)
                {
                    if (Map[x - 1, oldy] != -1)
                        return false;
                }
                if (x - oldx == -2)
                {
                    if (Map[x + 1, oldy] != -1)
                        return false;
                }
                if (y - oldy == 2)
                {
                    if (Map[oldx, y - 1] != -1)
                        return false;
                }
                if (y - oldy == -2)
                {
                    if (Map[oldx, y + 1] != -1)
                        return false;
                }
                return true;
            }
            if (qi_name == "车" || qi_name == "车")
            {
                //判断是否直线
                if ((x - oldx)*(y - oldy) != 0) return false;
                //判断是否隔有棋子
                if (x != oldx)
                {
                    if (oldx > x)
                    {
                        int t = x;
                        x = oldx;
                        oldx = t;
                    }
                    for (i = oldx; i <= x; i += 1)
                    {
                        if (i != x && i != oldx)
                        {
                            if (Map[i, y] != -1)
                                return false;
                        }
                    }
                }
                if (y != oldy)
                {
                    if (oldy > y)
                    {
                        int t = y;
                        y = oldy;
                        oldy = t;
                    }
                    for (j = oldy; j <= y; j += 1)
                    {
                        if (j != y && j != oldy)
                        {
                            if (Map[x, j] != -1)
                                return false;
                        }
                    }
                }
                return true;
            }
            if (qi_name == "炮" || qi_name == "炮")
            {
                bool swapflagx = false;
                bool swapflagy = false;
                if ((x - oldx)*(y - oldy) != 0) return false;
                c = 0;
                if (x != oldx)
                {
                    if (oldx > x)
                    {
                        int t = x;
                        x = oldx;
                        oldx = t;
                        swapflagx = true;
                    }
                    for (i = oldx; i <= x; i += 1)
                    {
                        if (i != x && i != oldx)
                        {
                            if (Map[i, y] != -1)
                                c = c + 1;
                        }
                    }
                }
                if (y != oldy)
                {
                    if (oldy > y)
                    {
                        int t = y;
                        y = oldy;
                        oldy = t;
                        swapflagy = true;
                    }
                    for (j = oldy; j <= y; j += 1)
                    {
                        if (j != y && j != oldy)
                        {
                            if (Map[x, j] != -1)
                                c = c + 1;
                        }
                    }
                }
                if (c > 1) return false; //与目标处间隔1个以上棋子
                if (c == 0) //与目标处无间隔棋子
                {
                    if (swapflagx)
                    {
                        int t = x;
                        x = oldx;
                        oldx = t;
                    }
                    if (swapflagy)
                    {
                        int t = y;
                        y = oldy;
                        oldy = t;
                    }
                    if (Map[x, y] != -1) return false;
                }
                if (c == 1) //与目标处间隔1个棋子
                {
                    if (swapflagx)
                    {
                        int t = x;
                        x = oldx;
                        oldx = t;
                    }
                    if (swapflagy)
                    {
                        int t = y;
                        y = oldy;
                        oldy = t;
                    }
                    if (Map[x, y] == -1) //如果目标处无棋子，则不能走此步
                        return false;
                }
                return true;
            }
            if (qi_name == "卒" || qi_name == "兵")
            {
                if ((x - oldx)*(y - oldy) != 0)
                    return false;
                if (Math.Abs(x - oldx) > 1 || Math.Abs(y - oldy) > 1)
                    return false;
                if (y >= 6 && (x - oldx) != 0)
                    return false;
                if (y - oldy > 0)
                    return false;
                return true;
            }
            return true;
        }

        //public bool CanMove(int idx, int x, int y) //判断被选中棋子是否可以移动 
        //{
        //    return false;
        //}
        public string Create_pu(Chess firstchess, int x2, int y2)
        {
            string chess_p;
            string step_info; //棋子和每步信息         
            int x1, y1; //(x1,y1)是被移动棋子的原处棋盘坐标
            x1 = firstchess.pos.X;
            y1 = firstchess.pos.Y;
            chess_p = firstchess.typeName;
            step_info = "";
            //(x2,y2)是被移动棋子目的棋盘坐标 
            if (find_Other(firstchess, x1, y1) != null) //前后处理如前车进一 
            {
                Chess other;
                other = find_Other(firstchess, x1, y1); //找到另一个与移动棋子同名棋子             
                if (other.pos.Y > y1)
                {
                    step_info = "前" + chess_p;
                }
                else
                {
                    step_info = "后" + chess_p;
                }
            }
            else //非前后处理
            {
                step_info = chess_p + (10 - x1).ToString();
            }
            if (y1 != y2 & x1 == x2) //进退处理－－－车兵跑帅
            {
                //如果是直线进，y坐标变化如 炮八进二 
                if (y2 > y1) //退 
                {
                    step_info += "退" + Math.Abs(y2 - y1);
                }
                if (y2 < y1) //进
                {
                    step_info += "进" + Math.Abs(y2 - y1);
                }
            }
            if (y1 == y2 & x1 != x2) //平处理 
            {
                step_info += "平" + (10 - x2);
            }
            //如果是斜线进，x,y坐标同时变化 如马二进三 
            if (y1 != y2 & x1 != x2)
            {
                //进退处理－－－马相士 
                if (y2 > y1) //退
                {
                    step_info += "退" + (10 - x2);
                }
                if (y2 < y1) //进 
                {
                    step_info += "进" + (10 - x2);
                }
            }
            if (firstchess.player == REDPLAYER)
                step_info = ConvertTOHazi(step_info);
            return step_info;
        }

        private string ConvertTOHazi(string s)
        {
            //阿拉伯数字数字转换成汉字 
            string[] NumChinese =
                {"零", "一", "二", "三", "四", "五", "六", "七", "八", "九"};
            char[] charNum = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            string s1 = "";
            foreach (char c in s)
            {
                if (Array.IndexOf(charNum, c) < 0) //如果是非数字字符 
                {
                    s1 = s1 + c;
                }
                else
                {
                    s1 += NumChinese[c - '0'];
                }
            }
            return s1;
        }

        //find_Other(chess_p, x1, y1)实现判断同一垂直线是否有同名棋子。
        private Chess find_Other(Chess firstchess, int x, int y)
        {
            //原处垂直线上是否有同子，即两个炮等在同一垂直线 
            int idx;
            int y1;
            for (y1 = 1; y1 <= 10; y1++)
            {
                idx = Map[x, y1];
                if (idx == -1) continue;
                if (chess[idx].player == firstchess.player
                    && chess[idx].typeName == firstchess.typeName)
                {
                    if (y != y1) return chess[idx];
                }
            }
            return null; //没有找到 
        }
    }
}