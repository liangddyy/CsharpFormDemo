using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace _01订单.数据库
{
    class Opreate
    {
        //连接mysql 测试
        public MySqlConnection mysqlConn()
        {
            string query = "select * from t_user";
            MySqlConnection myConnection = new MySqlConnection("server=182.18.21.109;user id=root;password=a0000AAA;database=zjwdb_392412");
            return myConnection;
        }
        //连接sqlserver
        public SqlConnection conn()                         //定义连接方法，返回的是连接对象
        {
            //数据库连字符串
            string con = "data source=LEON;initial catalog=zhenghang;integrated security=sspi;";
            //string con = "data source=10.12.94.110;User id=sa;Password=sa;initial catalog=soft;";
            SqlConnection conn = new SqlConnection(con);            //创建连接对象
            return conn;                                    //返回连接对象
        }

        public bool OPSQL(string SQLcmd)    //定义返回值类型为bool的OPSQL类//SQL数据库单条记录的增删改操作
        {
            SqlConnection con = conn();                     //SQL数据库单条记录的增删改操作
            con.Open();                                 //打开连接
            SqlCommand cmd = new SqlCommand(SQLcmd, con);   //获得传来的SQL命令
            bool succ = true;                               //操作是否成功的标志
            try
            {
                cmd.ExecuteNonQuery();                      //执行传入的命令
            }
            catch (Exception e)                             //抛出异常
            {
                MessageBox.Show("操作有误！");               //操作失败信息
                succ = false;                                   //把标志设为失败操作
            }
            return succ;                                    //返回操作结果
        }

        public string FiledValue(string sqlcmd)                 //查询单条记录
        {
            string count = "";
            SqlConnection con = conn();                     //创建连接
            con.Open();                                 //打开连接
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            try
            {
                SqlDataReader rs = cmd.ExecuteReader();         //执行命令
                if (rs.Read())                              //读取数据
                {
                    count = rs[0].ToString();                   //读取查询结果的第一列的值，一般为id列
                }
            }
            catch (Exception e)                             //抛出异常
            {
                MessageBox.Show("操作有误！");               //操作失败提示
            }
            return count;                                   //返回数据集单条记录第一列的值
        }

        public DataTable GetDataTable(String str, String TableName) //自定义GetDataTable返回一个Table的数据集
        {
            DataSet ds = new DataSet();                     //定义数据集ds
            SqlDataAdapter da = new SqlDataAdapter(str, conn());    //定义SqlDataAdapter对象，
            try
            {
                da.Fill(ds, TableName);                     //填充ds
                return ds.Tables[0];                            //返回表集
            }
            catch
            {
                return new DataTable();                     //返回一个空的DataTable对象
            }
        }
       public List<string> getGoodsNumName()
        {
            List<string> numAndName = new List<string>();
            DataTable dt = GetDataTable("select id,name from goods", "goods");
            
            int lastRow = dt.Rows.Count;
            
            string flg = null;
            for (int i = 0; i < lastRow; i++)
            {
                flg = dt.Rows[i]["id"].ToString() + " - " + dt.Rows[i]["name"].ToString();
                numAndName.Add(flg.Replace(" ", ""));
            }
            return numAndName;
        }

        public List<string> getUserNumName()
        {
            List<string> numAndName = new List<string>();
            DataTable dt = GetDataTable("select id,name from user1", "user1");

            int lastRow = dt.Rows.Count;

            string flg = null;
            for (int i = 0; i < lastRow; i++)
            {
                flg = dt.Rows[i]["id"].ToString() + " - " + dt.Rows[i]["name"].ToString();
                numAndName.Add(flg.Replace(" ", ""));
            }
            return numAndName;
        }


    }
}
