using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 弹窗控件
{
    public partial class Form1 : Form
    {
        TaskbarNotifier taskbarNotifier1;//=new TaskbarNotifier();
        TaskbarNotifier taskbarNotifier2;// = new TaskbarNotifier();
        //taskbarNotifier2 = new TaskbarNotifier();
        TaskbarNotifier taskbarNotifier3;// = new TaskbarNotifier();
        public Form1()
        {
            InitializeComponent();
            taskbarNotifier1 = new TaskbarNotifier();
            taskbarNotifier1.SetBackgroundBitmap(Resource1.skin, Color.FromArgb(255, 0, 255));
            taskbarNotifier1.SetCloseBitmap(Resource1.close, Color.FromArgb(255, 0, 255), new Point(127, 8));
            taskbarNotifier1.TitleRectangle = new Rectangle(40, 9, 70, 25);
            taskbarNotifier1.ContentRectangle = new Rectangle(8, 41, 133, 68);
            taskbarNotifier1.TitleClick += new EventHandler(TitleClick);
            taskbarNotifier1.ContentClick += new EventHandler(ContentClick);
            taskbarNotifier1.CloseClick += new EventHandler(CloseClick);

            taskbarNotifier2 = new TaskbarNotifier();
            taskbarNotifier2.SetBackgroundBitmap(Resource1.skin2, Color.FromArgb(255, 0, 255));
            taskbarNotifier2.SetCloseBitmap(Resource1.close2, Color.FromArgb(255, 0, 255), new Point(262, 2));
            taskbarNotifier2.TitleRectangle = new Rectangle(60, 30, 176, 20);
            taskbarNotifier2.ContentRectangle = new Rectangle(116, 97, 197, 22);
            taskbarNotifier2.TitleClick += new EventHandler(TitleClick);
            taskbarNotifier2.ContentClick += new EventHandler(ContentClick);
            taskbarNotifier2.CloseClick += new EventHandler(CloseClick);

            taskbarNotifier3 = new TaskbarNotifier();
            taskbarNotifier3.SetBackgroundBitmap(Resource1.skin3, Color.FromArgb(255, 0, 255));
            taskbarNotifier3.SetCloseBitmap(Resource1.close3, Color.FromArgb(255, 0, 255), new Point(262, 2));
            taskbarNotifier3.TitleRectangle = new Rectangle(123, 80, 176, 16);
            taskbarNotifier3.ContentRectangle = new Rectangle(116, 97, 197, 22);
            taskbarNotifier3.TitleClick += new EventHandler(TitleClick);
            taskbarNotifier3.ContentClick += new EventHandler(ContentClick);
            taskbarNotifier3.CloseClick += new EventHandler(CloseClick);

            // Added Rev 002
            //taskbarNotifier3 = new TaskbarNotifier();
            //taskbarNotifier3.SetBackgroundBitmap(Resource1.skin3, Color.FromArgb(255, 0, 255));
            //taskbarNotifier3.SetCloseBitmap(Resource1.close, Color.FromArgb(255, 0, 255), new Point(280, 57));
            //taskbarNotifier3.TitleRectangle = new Rectangle(150, 57, 125, 28);
            //taskbarNotifier3.ContentRectangle = new Rectangle(75, 92, 215, 55);
            //taskbarNotifier3.TitleClick += new EventHandler(TitleClick);
            //taskbarNotifier3.ContentClick += new EventHandler(ContentClick);
            //taskbarNotifier3.CloseClick += new EventHandler(CloseClick);
        }

        void CloseClick(object obj, EventArgs ea)
        {
            MessageBox.Show("关闭按钮被点击");
        }

        void TitleClick(object obj, EventArgs ea)
        {
            MessageBox.Show("标题被点击");
        }

        void ContentClick(object obj, EventArgs ea)
        {
            MessageBox.Show("内容被点击");
        }

        static bool IsNumeric(string str)
        {
            if (str == null || str.Length == 0)
                return false;
            foreach (char c in str)
            {
                if (!Char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("输入一个标题和内容文本");
                return;
            }
            if (!IsNumeric(textBox3.Text) || !IsNumeric(textBox4.Text) || !IsNumeric(textBox5.Text))
            {
                MessageBox.Show("输入有效的延迟(整数)");
                return;
            }

            taskbarNotifier1.CloseClickable = checkBox2.Checked;
            taskbarNotifier1.TitleClickable = checkBox1.Checked;
            taskbarNotifier1.ContentClickable = checkBox3.Checked;
            taskbarNotifier1.EnableSelectionRectangle = checkBox4.Checked;
            taskbarNotifier1.KeepVisibleOnMousOver = checkBox5.Checked;	// Added Rev 002
            taskbarNotifier1.ReShowOnMouseOver = checkBox6.Checked;			// Added Rev 002
            taskbarNotifier1.Show(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //taskbarNotifier2 = new TaskbarNotifier();
            //taskbarNotifier2.SetBackgroundBitmap(Resource1.skin2, Color.FromArgb(255, 0, 255));
            //taskbarNotifier2.SetCloseBitmap(Resource1.close2, Color.FromArgb(255, 0, 255), new Point(262, 2));
            //taskbarNotifier2.TitleRectangle = new Rectangle(60, 30, 176, 20);
            //taskbarNotifier2.ContentRectangle = new Rectangle(116, 97, 197, 22);
            //taskbarNotifier2.TitleClick += new EventHandler(TitleClick);
            //taskbarNotifier2.ContentClick += new EventHandler(ContentClick);
            //taskbarNotifier2.CloseClick += new EventHandler(CloseClick);

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("输入一个标题和内容文本");
                return;
            }
            if (!IsNumeric(textBox3.Text) || !IsNumeric(textBox4.Text) || !IsNumeric(textBox5.Text))
            {
                MessageBox.Show("输入有效的延迟(整数)");
                return;
            }

            taskbarNotifier2.CloseClickable = checkBox2.Checked;
            taskbarNotifier2.TitleClickable = checkBox1.Checked;
            taskbarNotifier2.ContentClickable = checkBox3.Checked;
            taskbarNotifier2.EnableSelectionRectangle = checkBox4.Checked;
            taskbarNotifier2.KeepVisibleOnMousOver = checkBox5.Checked;	
            taskbarNotifier2.ReShowOnMouseOver = checkBox6.Checked;			
            taskbarNotifier2.Show(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("输入一个标题和内容文本");
                return;
            }
            if (!IsNumeric(textBox3.Text) || !IsNumeric(textBox4.Text) || !IsNumeric(textBox5.Text))
            {
                MessageBox.Show("输入有效的延迟(整数)");
                return;
            }

            taskbarNotifier3.CloseClickable = checkBox2.Checked;
            taskbarNotifier3.TitleClickable = checkBox1.Checked;
            taskbarNotifier3.ContentClickable = checkBox3.Checked;
            taskbarNotifier3.EnableSelectionRectangle = checkBox4.Checked;
            taskbarNotifier3.KeepVisibleOnMousOver = checkBox5.Checked;
            taskbarNotifier3.ReShowOnMouseOver = checkBox6.Checked;
            taskbarNotifier3.Show(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
