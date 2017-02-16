using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201604RFID.Ctrl
{
    class MsgManager
    {
        
        public static void saveIPmsg(string path, string[] lines)
        {
            System.IO.File.WriteAllLines(@path, lines);
        }

        //保存日志信息
        public static void savaMsg(string lines)
        {
            System.IO.File.WriteAllText(@"log.txt", lines);

        }

    }
}
