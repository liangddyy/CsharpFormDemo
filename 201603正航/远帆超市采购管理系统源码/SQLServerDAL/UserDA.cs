using System;
using System.Collections.Generic;
using System.Text;
using model;
using IDAL;
using System.Data;
using System.Data.SqlClient;
namespace SQLServerDAL
{
    public class UserDA:IDAL.IUser
    {
        public static string connStr =string.Empty;

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns>新增加项的ID</returns>
        public int insertUser(UserData user)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into [User] values(@name,@pwd,@purview)",conn);
            cmd.Parameters.AddWithValue("@name",user.Name);
            cmd.Parameters.AddWithValue("@pwd",user.Pwd);
            cmd.Parameters.AddWithValue("@purview",user.Purview);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        public int delUser(UserData user)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from [User] where id = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", user.ID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        //该源码下载自win.51aspx.com(５１ａｓｐｘ．ｃｏｍ)

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        public int updateUser(UserData user)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [user] set name = @name,pwd = @pwd,purview = @purview where ID = @id", conn);
            cmd.Parameters.AddWithValue("@id",user.ID);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@pwd", user.Pwd);
            cmd.Parameters.AddWithValue("@purview", user.Purview);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns>返回用户类的集合</returns>
        public List<UserData> selUser()
        {
            List<UserData> list = new List<UserData>();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [user]", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                UserData user = new UserData();
                user.ID = sdr.GetInt32(0);
                user.Name = sdr[1].ToString();
                user.Pwd = sdr[2].ToString();
                user.Purview = sdr.GetInt32(3);
                list.Add(user);
            }
            conn.Close();
            return list;
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns>返回用户ID</returns>
        public UserData logicUser(UserData user)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from [user] where name = @name and pwd = @pwd", conn);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@pwd", user.Pwd);
                SqlDataReader sdr = cmd.ExecuteReader();
                UserData u = null;
                sdr.Read();
                if(sdr.HasRows==false)
                    return u;
                u=new UserData();
                u.ID = sdr.GetInt32(0);
                u.Name = (string)sdr[1];
                u.Purview = (int)sdr[3];
                return u;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
