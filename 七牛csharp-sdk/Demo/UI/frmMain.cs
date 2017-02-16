using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.ADO;
using Demo.business;
using Demo.ibusiness;
using Demo.model;
using Demo.Manage;

namespace Demo
{
    public partial class frmMain : Form
    {
        private Upload upload = new Upload();
        private UploadDemo qNiu = new UploadDemo();
        private IFileManage fileManage = new FileManage();
        private ITypechoDA typechoManage = new TypechoDA();

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 上传附件并更新文本
        /// </summary>
        void uploadImgAndUpdateText()
        {
            String text = rtb_main.Text;
            String pathOld = null;
            String pathNew = null;
            String url = null;
            if (fileManage.getImgCount() > 0)
            {
                foreach (ImgFileMsg imgItem in fileManage.getImgFileList())
                {
                    pathOld = @"!\[" + imgItem.name + @"\]\((.*?)\)";

                    url = upload.SendFile(imgItem.path, new Uri("http://localhost/typecho/usr/upload_file.php"));

                    pathNew = @"![" + imgItem.name + @"](" + url + @")";

                    Regex regex = new Regex(pathOld);
                    text = regex.Replace(text, pathNew);

                    Console.WriteLine(url);

                }
            }
            rtb_main.Text = text;
        }

        /// <summary>
        /// 提交文章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void sendToTypecho()
        {
            Content content = new Content();
            content.Text = "<!--markdown-->" + rtb_main.Text;
            content.Slug = tB_slug.Text;
            content.Title = tB_title.Text;

            int cid = typechoManage.sendWrittings(content);

            if(content.Slug=="")
                typechoManage.updateSlug(cid);

            setHint("上传文章成功，id：" + cid);
            
        }

        /// <summary>
        /// 提交文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            uploadImgAndUpdateText();
            sendToTypecho();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            qNiu.initQNiu();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 读取文件信息并提取需要上传的附件信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //完整的文件路径
            String pathStr = ((System.Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            setHint("准备读取文件：" + pathStr);
            //文件路径
            fileManage.setTextFilePath(pathStr);

            //显示文本内容
            rtb_main.Text = fileManage.getTextFileText();

            tB_title.Text = System.IO.Path.GetFileNameWithoutExtension(pathStr);

            Regex regex = new Regex(@"!\[(?<name>.*?)\]\((?<path>.*?)\)");
            MatchCollection matches = regex.Matches(fileManage.getTextFileText());
            foreach (Match match in matches)
            {
                GroupCollection gc = match.Groups;
                ImgFileMsg item = new ImgFileMsg(gc["name"].Value, gc["path"].Value);
                fileManage.addImgItem(item);
            }
            setHint("找到 " + matches.Count + " 份附件");
            panel1.Visible = false;
        }

        /// <summary>
        /// 状态栏的提示
        /// </summary>
        /// <param name="hint"></param>
        void setHint(String hint)
        {
            tSSL_hint.Text = hint;
           
        }
    }
}
