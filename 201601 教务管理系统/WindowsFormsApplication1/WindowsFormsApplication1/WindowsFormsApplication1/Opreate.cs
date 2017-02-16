using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class Opreate
    {
        public SqlConnection conn()                         //定义连接方法，返回的是连接对象
        {
            //数据库连字符串
            string con = "data source=ORVNGE\\ORVNGE;initial catalog=soft;integrated security=sspi;";
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

        /*public SqlDataAdapter GetDataTable(string str, string TableName) //自定义GetDataTable返回一个Table的数据集
         {
            DataSet ds = new DataSet();                     //定义数据集ds
             SqlDataAdapter da = new SqlDataAdapter(str, conn());    //定义SqlDataAdapter对象，
             try
             {
                 da.Fill(ds, TableName);                     //填充ds
                 return ds.Tables[0];                            //返回表集
                 return da;
             }
             catch
             {
                 return new DataTable();                     //返回一个空的DataTable对象
                 return null;
             }
         }*/

        public DataTable GetDataTable(String str, String TableName) //赻隅砱GetDataTable殿隙珨跺Table腔杅擂摩
        {
            DataSet ds = new DataSet();                     //隅砱杅擂摩ds
            SqlDataAdapter da = new SqlDataAdapter(str, conn());    //隅砱SqlDataAdapter勤砓ㄛ
            try
            {
                da.Fill(ds, TableName);                     //沓喃ds
                return ds.Tables[0];                            //殿隙桶摩
            }
            catch
            {
                return new DataTable();                     //殿隙珨跺諾腔DataTable勤砓
            }
        }
        public int GetDataReader(string str)
        {
            SqlConnection con = conn();						//创建连接
            con.Open();									//打开连接
            SqlCommand cmd = new SqlCommand(str, con);

            int num = Convert.ToInt32(cmd.ExecuteScalar());

            return num;
        }
    }
}
