using System;
using System.Text;
using System.IO;

namespace SocketServer
{
    public static class Logger
    {
        private static object LOCK = new object();
        
        private static string filepath = AppDomain.CurrentDomain.BaseDirectory + @"Logs";

        public static void WriteError(string errorText)
        {
            lock (LOCK)
            {
                try
                {
                    if (!Directory.Exists(filepath))
                    {
                        Directory.CreateDirectory(filepath);
                    }
                    string fileName = filepath + @"\"
                        + DateTime.Now.Year.ToString()
                        + "_" + DateTime.Now.Month.ToString()
                        + "_" + DateTime.Now.Day.ToString()
                        + "_" + DateTime.Now.Hour.ToString() + ".txt";

                    using (FileStream log = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.Read))
                    {
                        errorText = DateTime.Now.Minute.ToString()
                           + "分" + DateTime.Now.Second.ToString()
                           + "秒" + DateTime.Now.Millisecond.ToString()
                           + "毫秒" + ":" + errorText + Environment.NewLine;
                        Byte[] error = Encoding.Default.GetBytes(errorText);
                        log.Write(error, 0, error.Length);
                        log.Flush();
                    }
                }
                catch (Exception e)
                {
                    //throw e;
                }
            }
        }
    }
}
