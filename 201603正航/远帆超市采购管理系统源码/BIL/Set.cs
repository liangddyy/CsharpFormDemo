using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using model;


namespace BIL
{
    public class Set
    {
        public static string path = "";
        public static UserData User = null;
        public static Set set = new Set();


        // 权限
        public const int Admin = 0;
        public const int Super = 1;
        public const int Ordinarily = 2;

        //数据库类型
        public const int Access = 0;
        public const int SqlServer = 1;


        public string ChaoName = "";
        public int interval = 10;//每隔多长时间刷新库存预警
        public string SmtpServer = "";
        public string SmtpUser = "";
        public string SmtpPwd = "";
        /// <summary>
        /// 数据库类型 
        /// </summary>
        public int DBType = 1;
        public string SqlServerName = "";
        public string SqlUser = "";
        public string SqlPwd = "";

        /// <summary>
        /// 读取配置
        /// </summary>
        public static void XmlDeserialize()
        {

            if (!File.Exists(Set.path))
                return;
            using (FileStream fs = new FileStream(Set.path, FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Set));
                //反序列化
                set = (Set)xs.Deserialize(fs);
            }
        }

        /// <summary>
        /// 写入配置
        /// </summary>
        public static void XmlSerializer()
        {
            using (FileStream fs = new FileStream(Set.path, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Set));
                //序列化
                xs.Serialize(fs, set);
            }
        }

    }
}
