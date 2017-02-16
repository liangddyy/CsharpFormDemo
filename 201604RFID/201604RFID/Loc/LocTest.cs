using System;
using System.Drawing;
using System.Windows.Forms;

namespace _201604RFID.Loc
{
    public class LocTest
    {
        const double DeviationRate = 1.2;
        public int TempCount { get; set; }


        public float[] Distance = new float[5];
        public MyPointD[] Anchor = new MyPointD[5];
        public MyPointD[] temptPoint = new MyPointD[8];


        public void setAnchor(Point p1, Point p2, Point p3, Point p4)
        {
            Anchor[1].X = p1.X;
            Anchor[1].Y = p1.Y;
            Anchor[2].X = p2.X;
            Anchor[2].Y = p2.Y;
            Anchor[3].X = p3.X;
            Anchor[3].Y = p3.Y;
            Anchor[4].X = p4.X;
            Anchor[4].Y = p4.Y;
        }

        public void setDistance(float[] floats)
        {
            Distance[1] = floats[1];
            Distance[2] = floats[2];
            Distance[3] = floats[3];
            Distance[4] = floats[4];
        }
        public MyPointD CalculatePoint()
        {
            TempCount = 0;
            float sumx = 0;
            float sumy = 0;

            GetTempPoint(2, 1, 3, 4);
            GetTempPoint(3, 1, 2, 4);
            GetTempPoint(4, 1, 2, 3);
            GetTempPoint(3, 2, 1, 4);
            GetTempPoint(4, 2, 1, 3);
            GetTempPoint(4, 3, 1, 2);

            if (TempCount > 0)
            {
                for (int i = 0; i < TempCount; i++)
                {
                    sumx += temptPoint[i].X;
                    sumy += temptPoint[i].Y;

                }
                temptPoint[TempCount].X = sumx / TempCount;
                temptPoint[TempCount].Y = sumy / TempCount;
                return temptPoint[TempCount];
            }

            return temptPoint[0];

        }
        private void GetTempPoint(int p1, int p2, int p3, int p4)
        {
            if (Distance[p1] < 0 || Distance[p2] < 0 || Distance[p3] < 0 || Distance[p4] < 0) return;

            MyPointD myPoint = GetThirdPoint(p1, p2, p3);

            if (myPoint.flag == 1)
            {

                temptPoint[TempCount] = myPoint;
                TempCount++;
            }

        }

        private MyPointD GetThirdPoint(int p1, int p2, int p3)
        {

            float d3 = GetDistance(Anchor[p1], Anchor[p2]);
            float d1 = Distance[p1];
            float d2 = Distance[p2];
            float t;

            MyPointD p3a = new MyPointD();
            MyPointD p3b = new MyPointD();
            p3a.flag = 0;
            p3b.flag = 0;

            // 处理三个距离值无法形成一个三角形的情况,如果误差值在范围内，认为三点一直线
            if (d1 > d2 + d3)
            {
                if (d1 < (d2 + d3) * DeviationRate)
                {
                    t = (d1 / d3);
                    p3a.X = Anchor[p1].X + (Anchor[p2].X - Anchor[p1].X) * t;
                    p3a.Y = Anchor[p1].Y + (Anchor[p2].Y - Anchor[p1].Y) * t;
                    p3a.flag = 1;

                }
                return p3a;
            }
            if (d2 > d1 + d3)
            {
                if (d2 < (d1 + d3) * DeviationRate)
                {
                    t = (d1 / d3);
                    p3a.X = Anchor[p2].X + (Anchor[p1].X - Anchor[p2].X) * t;
                    p3a.Y = Anchor[p2].Y + (Anchor[p1].Y - Anchor[p2].Y) * t;
                    p3a.flag = 1;
                }
                return p3a;
            }
            if (d3 > d1 + d2)
            {
                if (d3 < (d1 + d2) * DeviationRate)
                {
                    t = d1 / d2;
                    //p3a.X = Anchor[p1].X + (Anchor[p2].X - Anchor[p1].X) * t;
                    p3a.X = Anchor[p1].X + (Anchor[p2].X - Anchor[p1].X) * d1 / (d1 + d2);
                    p3a.Y = Anchor[p1].Y + (Anchor[p2].Y - Anchor[p1].Y) * d1 / (d1 + d2);
                    //p3a.Y = Anchor[p1].Y + (Anchor[p2].Y - Anchor[p1].Y) * t;
                    p3a.flag = 1;
                }
                return p3a;
            }

            //计算d1和d3形成的夹角
            float A = ArcCos(System.Convert.ToSingle((d1 * d1 + d3 * d3 - d2 * d2) / (2 * d1 * d3)));

            // 计算第一种可能的第3点坐标
            t = (float)(A + ArcCos(System.Convert.ToSingle((Anchor[p1].Y - Anchor[p2].Y) / d3)) - 2 * Math.Atan(1));

            //计算d1与横坐标的夹角
            if (Anchor[p1].X < Anchor[p2].X)
            {
                p3a.X = (float)(Anchor[p1].X + d1 * Math.Cos(t));
            }
            else
            {
                p3a.X = (float)(Anchor[p1].X - d1 * Math.Cos(t));
            }
            p3a.Y = (float)(Anchor[p1].Y + d1 * Math.Sin(t));
            p3a.flag = 1;

            // 计算第二种可能的第3点坐标
            t = (float)(A - ArcCos(System.Convert.ToSingle((Anchor[p1].Y - Anchor[p2].Y) / d3)) + 2 * Math.Atan(1));

            //计算d1与横坐标的夹角
            if (Anchor[p1].X < Anchor[p2].X)
            {
                p3b.X = (float)(Anchor[p1].X + d1 * Math.Cos(t));

            }
            else
            {
                p3b.X = (float)(Anchor[p1].X - d1 * Math.Cos(t));
            }
            p3b.Y = (float)(Anchor[p1].Y - d1 * Math.Sin(t));
            p3b.flag = 1;

            // 选有效点返回 如果两个点有效 则选择与测量值接近的点
            if (p3b.flag == 1 || p3a.flag == 1)
            {
                return GetDistance(p3a, Anchor[p3]) - Distance[p3] < GetDistance(p3b, Anchor[p3]) - Distance[p3]
                    ? p3a
                    : p3b;
            }
            return p3a;
        }
        private float ArcCos(float x)
        {
            float returnValue;
            // 计算反余玄
            if ((x > 0.9999999) && (x < 1.0000001))
            {
                returnValue = 0;
                return returnValue;
            }
            if ((x > -1.0000001) && (x < -0.9999999))
            {
                returnValue = System.Convert.ToSingle(4 * Math.Atan(1));
                return returnValue;
            }
            returnValue = System.Convert.ToSingle(Math.Atan(-x / Math.Sqrt(-x * x + 1)) + 2 * Math.Atan(1));
            return returnValue;
        }
        private float GetDistance(MyPointD p1, MyPointD p2)
        {
            return System.Convert.ToSingle(System.Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y)));
        }
    }
}