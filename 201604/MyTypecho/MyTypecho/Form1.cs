using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTypecho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex=new Regex("c(.*?)a");
            MatchCollection matches =  regex.Matches("![QQ截图20160423222415](QQ截图20160423222415.png)dsfsfdkfdskj![基德](D:\基德.jpeg)");

            //string text = System.IO.File.ReadAllText(@"D:\Personal\Desktop\test.md");
            //srichTextBox1.Text = str;
            Console.WriteLine("找到 "+matches.Count);
            foreach (Match match in matches)
            {
                
                //GroupCollection groups = match.Groups;
                Console.WriteLine(match.Value);
            }

        }
    }
}
