using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Demo.business;
using Demo.Conf;
using Demo.model;
using Qiniu.IO;
using Qiniu.RS;

namespace Demo
{
    /// <summary>
    /// 上传资源到七牛云
    /// </summary>
    public class UploadDemo
    {
        IOClient target = new IOClient();
        PutExtra extra = new PutExtra();
        private String dateStr = Tools.getDataTimeString()+"-";
        
        //设置上传的空间
        String bucket = "data-539go"; //todo 从配置文件读取

        public void initQNiu()
        {
            //todo 从文件读取
            //设置账号的AK和SK
            Qiniu.Conf.Config.ACCESS_KEY = "lOnSnV3fRbudCmLJOKuGl2S4Fp35o3DDsPoktEB-";
            Qiniu.Conf.Config.SECRET_KEY = "L-1BEXCzXCYIf8p4Ob-_V-bptoCVzOYayfV15l0Q";
        }

        public String uploadImg(ImgFileMsg item)
        {
            String key = item.name;

            //todo 添加日期
            //添加文件后缀

            //Regex regex = new Regex(@"\.(jpg|jpeg|bmp|png)");
            Regex regex = Setting.getRegexForType();

            String str = regex.Match(item.path).Value;
            if (str != "")
                key = dateStr + item.name + str;
            else
            {
                Console.WriteLine("不支持的文件格式");
                return null;
            }

            //覆盖上传
            PutPolicy put = new PutPolicy(bucket + ":" + key, 3600);

            //调用Token()方法生成上传的Token
            string upToken = put.Token();

            PutRet ret = target.PutFile(upToken, key, item.path, extra);

            //todo 上传成功的反馈
            //MessageBox.Show(ret.key.ToString());
            return Setting.qiniuUrl + ret.key.ToString();
        }
        public void uploadFile(String name, String filePath)
        {
            String key = name;
            
            //todo 添加日期
            //添加文件后缀
            Regex regex = new Regex(@"\.(jpg|jpeg|bmp|png)");
            String str = regex.Match(filePath).Value;
            if (str != "")
                key = name + str;
            else
            {
                MessageBox.Show("不支持的格式");
                return;
            }

            //覆盖上传
            PutPolicy put = new PutPolicy(bucket + ":" + key, 3600);
            
            //调用Token()方法生成上传的Token
            string upToken = put.Token();

            PutRet ret = target.PutFile(upToken, key, filePath, extra);

            //todo 上传成功的反馈
            //MessageBox.Show(ret.key.ToString());
        }
        public void TestuploadFile()
        {
            //设置上传的空间
            String bucket = "data-539go";
            //设置上传的文件的key值
            String key = "test.png";

            //普通上传,只需要设置上传的空间名就可以了,第二个参数可以设定token过期时间
            //PutPolicy put = new PutPolicy(bucket);
            PutPolicy put = new PutPolicy(bucket + ":" + key, 3600);

            //设置callbackUrl以及callbackBody,七牛将文件名和文件大小回调给业务服务器
            //            put.CallBackUrl = "http://your.domain.com/callback";
            //            put.CallBackBody = "filename=$(fname)&filesize=$(fsize)";

            //调用Token()方法生成上传的Token
            string upToken = put.Token();
            //上传文件的路径
            String filePath = @"D:\Personal\Desktop\test.png";

            PutRet ret = target.PutFile(upToken, key, filePath, extra);
            //打印出相应的信息
            //            Console.WriteLine(ret.Response.ToString());
            //            Console.WriteLine(ret.key);
            //            Console.ReadLine();
            MessageBox.Show(ret.key.ToString());

        }
    }
}