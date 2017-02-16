using System.Drawing;
using 网络象棋.Properties;

namespace 网络象棋
{
    internal class Chess //棋子类 
    {
        public const short REDPLAYER = 1;
        public const short BLACKPLAYER = 0;
        private readonly Bitmap chessImage; //棋子图案
        public short player; //红子为REDPLAYER，黑子为BLACKPLAYER
        public Point pos; //位置
        public string typeName; // 帅、士... 

        public Chess(short player, string typeName, Point chesspos)
        {
            this.player = player;
            this.typeName = typeName;
            pos = chesspos;
            //初始化棋子图案
            if (player == REDPLAYER)
            {
                switch (typeName)
                {
                    case "帅":
                        chessImage = Resources.红帅;
                        break;
                    case "仕":
                        chessImage = Resources.红仕;
                        break;
                    case "相":
                        chessImage = Resources.红相;
                        break;
                    case "马":
                        chessImage = Resources.红马;
                        break;
                    case "车":
                        chessImage = Resources.红车;
                        break;
                    case "炮":
                        chessImage = Resources.红炮;
                        break;
                    case "兵":
                        chessImage = Resources.红兵;
                        break;
                }
            }
            else //黑方棋子
            {
                switch (typeName)
                {
                    case "将":
                        chessImage = Resources.黑将;
                        break;
                    case "士":
                        chessImage = Resources.黑士;
                        break;
                    case "象":
                        chessImage = Resources.黑象;
                        break;
                    case "马":
                        chessImage = Resources.黑马;
                        break;
                    case "车":
                        chessImage = Resources.黑车;
                        break;
                    case "炮":
                        chessImage = Resources.黑炮;
                        break;
                    case "卒":
                        chessImage = Resources.黑卒;
                        break;
                }
            }
        }

        public void SetPos(int x, int y) //设置棋子位子
        {
            pos.X = x;
            pos.Y = y;
        }

        public void ReversePos() //棋子位置对调
        {
            pos.X = 10 - pos.X;
            pos.Y = 11 - pos.Y;
        }

        public void Draw(Graphics g) // 绘制自己到棋盘上 
        {
            g.DrawImage(chessImage, pos.X*40 - 40, pos.Y*40 - 40, 40, 40);
        }

        public void Draw(Image img)
        {
            Graphics g = Graphics.FromImage(img);
            Rectangle r = new Rectangle(pos.X*40 - 40, pos.Y*40 - 40, 40, 40);
            g.DrawImage(chessImage, r);
        }

        public void DrawSelectedChess(Graphics g)
        {
            //画选中方块的示意边框线
            Pen myPen = new Pen(Color.Black, 3);
            Rectangle r = new Rectangle(pos.X*40 - 40, pos.Y*40 - 40, 40, 40);
            g.DrawRectangle(myPen, r);
        }

        public void UnDrawSelectedChess(Graphics g, Color c) // 绘制自己到棋盘上 
        {
            //擦除选中方块的示意边框线
            Pen myPen = new Pen(c, 3);
            Rectangle r = new Rectangle(pos.X*40 - 40, pos.Y*40 - 40, 40, 40);
            g.DrawRectangle(myPen, r);
            Draw(g);
        }
    }
}