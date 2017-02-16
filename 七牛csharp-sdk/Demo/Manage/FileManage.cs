using System.Collections.Generic;
using Demo.Conf;
using Demo.ibusiness;
using Demo.model;

namespace Demo.business
{
    public class FileManage :IFileManage
    {
        /// <summary>
        /// 管理文本以及附件
        /// </summary>
        public List<ImgFileMsg> imgList = new List<ImgFileMsg>(); 
        private TextFileMsg _textTextFile =new TextFileMsg();

        public void setTextFilePath(string path)
        {
            _textTextFile.Text = System.IO.File.ReadAllText(path);
            _textTextFile.Path = path;
        }

        public void setTextFileText(string text)
        {
            _textTextFile.Text = text;
        }

        public void setTextName(string name)
        {
            _textTextFile.Name = name;
        }

        public string getTextName()
        {
            return _textTextFile.Name;
        }

        public string getTextFileText()
        {
            return _textTextFile.Text;
        }

        public string getTextFilePath()
        {
            return _textTextFile.Path;
        }

        /// <summary>
        /// 添加需要上传的文件名以及文件路径
        /// </summary>
        /// <param name="item"></param>
        public void addImgItem(ImgFileMsg item)
        {
            imgList.Add(item);
        }

        public List<ImgFileMsg> getImgFileList()
        {
            return imgList;
        }

        public int getImgCount()
        {
            return imgList.Count;
        }



    }
}