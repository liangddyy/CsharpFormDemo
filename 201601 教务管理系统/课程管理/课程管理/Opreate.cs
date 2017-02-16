using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务管理系统
{
    class Opreate
    {
        public SqlConnection conn()                         //定义连接方法，返回的是连接对象
        {
            //数据库连字符串
            string con = "data source=LEON;initial catalog=soft;integrated security=sspi;";
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
        //根据表student的major获取sno-name
        public List<string> retSnoAndNameFromMajor(string major)
        {
            List<string> retSnoAndName = new List<string>();
            DataTable dt = GetDataTable("select sno,sname from student where profession='" + major + " ' ", "student");
            int lastRow = retTotalRow("select count(*) from student where profession='" + major + " ' ");
            string flg = null;
            for (int i = 0; i < lastRow; i++)
            {
                flg = dt.Rows[i]["sno"].ToString() + "-" + dt.Rows[i]["sname"].ToString();
                retSnoAndName.Add(flg.Replace(" ", ""));
            }
            return retSnoAndName;
        }
        //返回数据库记录数量
        public int retTotalRow(string SQLcmd)
        {
            int ret = 0;
            SqlConnection con = conn();
            con.Open();
            SqlCommand cmd = new SqlCommand(SQLcmd, con);
            try
            {
                ret = (int)cmd.ExecuteScalar();

            }
            catch (Exception e)
            {
                MessageBox.Show("出现异常");
            }
            finally
            {
                con.Close();
            }
            return ret;
        }


        //保存数据库中表course所有的cno-cname
        public List<string> retCnoAndCnameFromCourse()
        {
            List<string> retCnoAndCname = new List<string>();
            DataTable dt = GetDataTable("select cno,cname from course", "course");
            int lastRow = retTotalRow("select count(*) from course");
            string flg = null;
            for (int i = 0; i < lastRow; i++)
            {
                flg = dt.Rows[i]["cno"].ToString() + "-" + dt.Rows[i]["cname"].ToString();
                retCnoAndCname.Add(flg.Replace(" ", ""));
            }
            return retCnoAndCname;
        }

        //选取某同学没有选的课程跟课程名
        public List<string> retCnoAndCname(string sno)
        {
            List<string> retCnoAndCname = retCnoAndCnameFromCourse();
            List<string> selectCnoAndCname = retSelectCnoAndCname(sno);
            string flg = null;
            for (int i = 0; i < selectCnoAndCname.Count; i++)
            {
                for (int j = retCnoAndCname.Count - 1; j >= 0; j--)
                {
                    if (selectCnoAndCname[i].Equals(retCnoAndCname[j]))
                    {
                        retCnoAndCname.RemoveAt(j);
                    }
                }

            }
            return retCnoAndCname;
        }

        //选取某同学选的课程跟课程名 stumessage
        public List<string> retSelectCnoAndCname(string sno)
        {
            List<string> retSelectCnoAndCname = new List<string>();
            DataTable dt = GetDataTable("select s.sno,s.sname,c.cno,cname,ccategory,score.grade from course c," +
                 "student s , score where s.sno = score.sno and score.cno = c.cno and s.sno='" + sno + " ' ", "student,score,course");
            int lastRow = retTotalRow("select count(*) from course c,student s , score where s.sno = score.sno and score.cno = c.cno and s.sno='" + sno + " ' ");
            string flg = null;
            for (int i = 0; i < lastRow; i++)
            {
                flg = (dt.Rows[i]["cno"].ToString() + "-" + dt.Rows[i]["cname"].ToString()).Replace(" ", "");
                retSelectCnoAndCname.Add(flg);
            }
            return retSelectCnoAndCname;
        }

        //用于教务管理系统 soft表
        public List<string> getCnoAndCname(string major)
        {
            List<string> CnoAndCname = new List<string>();
            DataTable dt = GetDataTable("select t.cno,c.cname from course c,Teacher_teaching t where c.cno=t.cno", "Teacher_teaching,course");
            //只返回登录老师所 教学的课程
            //int lastRow = retTotalRow("select count(*) from Teacher_teaching");
            int lastRow = 2;
                /*  where profession='" + major + " ' ");*/
            string flg = null;
            for (int i = 0; i < lastRow; i++)
            {
                flg = dt.Rows[i]["cno"].ToString() + "-" + dt.Rows[i]["cname"].ToString();
                CnoAndCname.Add(flg.Replace(" ", ""));
            }
            return CnoAndCname;
        }

    }
}