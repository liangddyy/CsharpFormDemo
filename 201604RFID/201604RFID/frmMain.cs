using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _201604RFID.Ctrl;
using _201604RFID.Loc;
using _201604RFID.View;

namespace _201604RFID
{
    public partial class frmMain : Form
    {
        private int selectIDindex = 0;

        private Loc.LocTest locDemo = new LocTest();
        private MyPointD p0 = new MyPointD();

        private Pen pen = new Pen(Color.Blue);
        SolidBrush s = new SolidBrush(Color.Red);
        SolidBrush s1 = new SolidBrush(Color.Blue);
        private int radius = 10;

        private Graphics gra;

        private int temp = 100;

        private string[] lines;
        System.DateTime currentTime;//保存时间信息

        private float[] floats = new float[5];
        private string[] strs;
        private float size = 100;

        private MyPointP mypoint = new MyPointP();
        public frmMain()
        {
            InitializeComponent();
        }
        private void setIPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 设置距离文件路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择距离文件的保存路径";

            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                DistanceManager.Path = dilog.SelectedPath + "\\sendData.txt";
                initComboBox();
                AddHintMessage("选择了文件路径：", DistanceManager.Path);
            }
            
        }

        public void initComboBox()
        {
            loadFileToLines();
            comboBox1.Items.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                comboBox1.Items.Add(lines[i].Split(' ')[0]);
            }
        }
        public void loadFileToLines()
        {
            lines = System.IO.File.ReadAllLines(@DistanceManager.Path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gra = this.pictureBox1.CreateGraphics();
        }

        private string GetTimeNow()
        {
            currentTime = System.DateTime.Now;
            return currentTime.ToString("T");

        }
        private void AddHintMessage(String hint, String msg)
        {

            HintMessage.AppendText(Environment.NewLine + GetTimeNow() + hint + msg);
        }
        private void AddMessage(String msg)
        {
            HintMessage.AppendText(Environment.NewLine + msg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DistanceManager.Path == null)
            {
                AddMessage("未配置文件路径");
                return;
            }
            else
            {
                loadFileToLines();

                AddHintMessage("距离信息：", lines[0]);

                setDistance(lines[selectIDindex]);
                
                locDemo.setAnchor(MyPointP.p1, MyPointP.p2, MyPointP.p3, MyPointP.p4);
                locDemo.setDistance(floats);
                p0 = locDemo.CalculatePoint();

                AddMessagePoint(floats[0].ToString(),p0);

                draw();
                drawPoint(p0);//标签
            }

        }

        private void AddMessagePoint(String str, MyPointD myp0)
        {
            float X = myp0.X / size;
            float Y = myp0.Y / size;
            HintMessage.AppendText(Environment.NewLine + "标签号：" + str + " 坐标: (" + X.ToString() + "," + Y.ToString() + ")");
        }

        private void drawPoint(MyPointD point)
        {
            gra.FillEllipse(s1, GetDrawXpoint(point.X, radius), GetDrawYpoint(point.Y, radius), radius * 2, radius * 2);
        }

        public void setDistance(string line)
        {
            strs = line.Split(' ');
            floats[0] = float.Parse(strs[0]);
            floats[1] = float.Parse(strs[1]) * size;
            floats[2] = float.Parse(strs[2]) * size;
            floats[3] = float.Parse(strs[3]) * size;
            floats[4] = float.Parse(strs[4]) * size;
        }

        private void 运行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                startOrStop.Text = "停止";
            else
            {
                startOrStop.Text = "运行";

            }
        }
        //根据实际坐标得到绘图坐标
        
        private float GetDrawX(int x, float r)
        {
            return (x + temp - r);
        }
        private float GetDrawXpoint(float x, float r)
        {
            return (x + temp - r);
        }
        
        private float GetDrawY(int y, float r)
        {
            return (pictureBox1.Height - y - temp - r);
        }
        private float GetDrawYpoint(float y, float r)
        {
            return (pictureBox1.Height - y - temp - r);
        }
        private void draw()
        {
            gra.Clear(Color.White);

            //绘制参考点
            gra.FillEllipse(s, GetDrawX(mypoint.getP1().X, radius), GetDrawY(mypoint.getP1().Y, radius), radius * 2, radius * 2);
            gra.FillEllipse(s, GetDrawX(mypoint.getP2().X, radius), GetDrawY(mypoint.getP2().Y, radius), radius * 2, radius * 2);
            gra.FillEllipse(s, GetDrawX(mypoint.getP3().X, radius), GetDrawY(mypoint.getP3().Y, radius), radius * 2, radius * 2);
            gra.FillEllipse(s, GetDrawX(mypoint.getP4().X, radius), GetDrawY(mypoint.getP4().Y, radius), radius * 2, radius * 2);
            //gra.DrawLine(pen,GetDrawXpoint(0),GetDrawYpoint(0),GetDrawXpoint(100),GetDrawYpoint(0));
            //绘制范围
            gra.DrawEllipse(pen, GetDrawX(mypoint.getP1().X, floats[1]), GetDrawY(mypoint.getP1().Y, floats[1]), floats[1] * 2, floats[1] * 2);
            gra.DrawEllipse(pen, GetDrawX(mypoint.getP2().X, floats[2]), GetDrawY(mypoint.getP2().Y, floats[2]), floats[2] * 2, floats[2] * 2);
            gra.DrawEllipse(pen, GetDrawX(mypoint.getP3().X, floats[3]), GetDrawY(mypoint.getP3().Y, floats[3]), floats[3] * 2, floats[3] * 2);
            gra.DrawEllipse(pen, GetDrawX(mypoint.getP4().X, floats[4]), GetDrawY(mypoint.getP4().Y, floats[4]), floats[4] * 2, floats[4] * 2);
        }

        private void 设置IPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new setIP();
            frm.ShowDialog(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectIDindex = comboBox1.SelectedIndex;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MsgManager.savaMsg(HintMessage.Text.ToString());
            MessageBox.Show("保存成功");

        }
        private void 设置锚点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new setAchor();
            frm.ShowDialog(this);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
