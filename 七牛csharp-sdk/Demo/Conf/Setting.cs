using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo.Conf
{
    class Setting
    {
        /*
         * 配置typecho信息
         * 服务器信息
         */
        public static String sqlAddr;
        public static String databaseName;
        public static String sqlUserName;
        public static String sqlUserPwd;

        public static bool isInit = false;

        /*
         * 七牛云相关信息
         */
        public static String qiniuUrl= @"http://7xpcnw.com1.z0.glb.clouddn.com/";

        //todo 检测配置文件是否有信息
        public bool init()
        {
            return false;
        }

        //todo 可以初始化
        /// <summary>
        /// 上传的文件类型
        /// </summary>
        private static Regex regex = new Regex(@"\.(jpg|jpeg|bmp|png)");

        public static Regex getRegexForType()
        {
            return regex;
        }
    }
}
