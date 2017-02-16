using System;
using System.Collections.Generic;
using System.Text;
using model;
using IDAL;
using System.Data;
using System.Data.SqlClient;
namespace SQLServerDAL
{
    public class MerchandiseTypeDA:IDAL.IMerchandiseType
    {
        static string connStr = UserDA.connStr;
        //private int _iD;
        //private string _name;
        //private int _parentID;
        /// <summary>
        /// 插入商品类别
        /// </summary>
        /// <param name="merType">商品类别类</param>
        /// <returns>返回新增加记录的自动编号</returns>
        public int insertMerchandiseType(MerchandiseTypeData merType)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into MerchandiseType values(@name,@parentID)", conn);
            cmd.Parameters.AddWithValue("@name", merType.Name);
            cmd.Parameters.AddWithValue("@parentID", merType.ParentID);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
       }
        /// <summary>
        /// 删除商品类别
        /// </summary>
        /// <param name="merType">商品类别类</param>
        /// <returns></returns>
        public int delMerchandiseType(MerchandiseTypeData merType)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from MerchandiseType where id = @id", conn);
            cmd.Parameters.AddWithValue("@id",merType.ID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 修改商品类别
        /// </summary>
        /// <param name="merType">商品类别类</param>
        /// <returns></returns>
        public int updateMerchandiseType(MerchandiseTypeData merType)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update MerchandiseType set name = @name,parentID = @parentID where id = @id", conn);
            cmd.Parameters.AddWithValue("@id",merType.ID);
            cmd.Parameters.AddWithValue("@name", merType.Name);
            cmd.Parameters.AddWithValue("@parentID", merType.ParentID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 查询商品类别
        /// </summary>
        /// <param name="merType">商品类别类</param>
        /// <returns>返回商品类别的集合</returns>
        public List<MerchandiseTypeData> selMerchandiseType()
        {
            List<MerchandiseTypeData> list = new List<MerchandiseTypeData>();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from MerchandiseType",conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                MerchandiseTypeData mer = new MerchandiseTypeData();
                mer.ID = (int)dr[0];
                mer.Name = dr[1].ToString();
                mer.ParentID = (int)dr[2];
                list.Add(mer);
            }
            return list;
        }
    }
}
