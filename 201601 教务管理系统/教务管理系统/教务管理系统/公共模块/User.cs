using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教务管理系统
{
    public static class User
    {
        static string uNo;
        static string uName;
        static string uPwd;
        static string uProperties;
        
        public static void setuProperties(string str)
        {
            uProperties = str;
        }
        public static string getuProperties()
        {
            return uProperties;
        }
        public static string getuNo()
        {
            return uNo;
        }
        public static string getuName()
        {
            return uName;
        }
        public static string getuPwd()
        {
            return uPwd;
        }
        public static void setuNo(string str)
        {
            uNo = str;
        }
        public static void setuName(string str)
        {
            uName = str;
        }
        public static void setuPwd(string str)
        {
            uPwd = str;
        }
    }
}
