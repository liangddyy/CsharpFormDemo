using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace BIL
{
    public class Other
    {
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="From">发送者邮件地址</param>
        /// <param name="to">发送到的邮件地址</param>
        /// <param name="title">邮件标题</param>
        /// <param name="MailTxt">邮件正文</param>
        /// <param name="smtp">Smtp服务器</param>
        /// <param name="port">Smtp服务器端口</param>
        /// <param name="user">Smtp邮件服务器帐号</param>
        /// <param name="pass">Smtp邮件服务器密码</param>
        public static void SendMail(string From,string to,string title,string MailTxt,string smtp,int port,string user,string pass)
        {
            MailMessage mail = new MailMessage(From, to, title, MailTxt);
            SmtpClient client = new SmtpClient(smtp, port);
            client.Credentials = new NetworkCredential(user, pass);
            client.Send(mail);

        }
    }
}
