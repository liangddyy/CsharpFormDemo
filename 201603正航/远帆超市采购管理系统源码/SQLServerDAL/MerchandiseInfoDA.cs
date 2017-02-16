using System;
using System.Collections.Generic;
using System.Text;
using model;
using IDAL;
using System.Data;
using System.Data.SqlClient;
namespace SQLServerDAL
{
    public class MerchandiseInfoDA:IDAL.IMerchandiseInfo
    {
        static string connStr = UserDA.connStr;
        //private int _iD;
        //private string _name;
        //private int _typeID;
        /// <summary>
        /// 插入商品信息
        /// </summary>
        /// <param name="merType">商品信息类</param>
        /// <returns></returns>
        public int insertMerchandiseType(MerchandiseInfoData merInfo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into MerchandiseInfo values(@name,@typeID,@Quantity,default)", conn);
            cmd.Parameters.AddWithValue("@name", merInfo.Name);
            cmd.Parameters.AddWithValue("@typeID", merInfo.TypeID);
            cmd.Parameters.AddWithValue("@Quantity", merInfo.Quantity);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
        }
        /// <summary>
        /// 删除商品信息
        /// </summary>
        /// <param name="merType">商品信息类</param>
        /// <returns></returns>
        public int delMerchandiseType(MerchandiseInfoData merInfo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from MerchandiseInfo where id = @id", conn);
            cmd.Parameters.AddWithValue("@id",merInfo.ID);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="merType">商品信息类</param>
        /// <returns></returns>
        public int updateMerchandiseType(MerchandiseInfoData merInfo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update MerchandiseInfo set name = @name,TypeID = @typeID,Quantity=@Quantity,Storage=@Storage where id = @id", conn);
            cmd.Parameters.AddWithValue("@id",merInfo.ID);
            cmd.Parameters.AddWithValue("@name", merInfo.Name);
            cmd.Parameters.AddWithValue("@typeID", merInfo.TypeID);
            cmd.Parameters.AddWithValue("@Quantity", merInfo.Quantity);
            cmd.Parameters.AddWithValue("@Storage", merInfo.Storage);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            return i;
        }
        /// <summary>
        /// 查询商品信息
        /// </summary>
        /// <param name="merType">商品信息类</param>
        /// <returns>返回商品信息的集合</returns>
        public List<MerchandiseInfoData> selMerchandiseType()
        {
            List<MerchandiseInfoData> list = new List<MerchandiseInfoData>();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from MerchandiseInfo",conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                MerchandiseInfoData mer = new MerchandiseInfoData();
                mer.ID = (int)dr[0];
                mer.Name = dr[1].ToString();
                mer.TypeID = (int)dr[2];
                mer.Quantity = (int)dr[3];
                mer.Storage = (int)dr[4];
                list.Add(mer);
            }
            return list;
        }
    }
}
