using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Demo.Sql
{
    class SQLCon
    {
        public static MySqlConnection conn=null;
        public static MySqlConnection getConn()
        {
            if (conn == null)
            {
                return new MySqlConnection("server=localhost;user id=root;password=;database=test;Charset=utf8;");
            }           
            return conn;
        }
    }
}
