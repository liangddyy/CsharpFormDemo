using System;
using System.Collections.Generic;
using System.Text;
using model;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace SQLServerDAL
{
    class DepotDA : IDAL.IDepot
    {
        static string connStr = @"server=localhost;database=demo;uid=sa;pwd=1";
        /// <summary>
        /// 插入库存管理信息
        /// </summary>
        /// <param name="depotData">库存管理类</param>
        /// <returns></returns>
        public int insertDepot(DepotData depotData)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into depot values(@MinfoID,@Quantity,@Hint)", conn);
            cmd.Parameters.AddWithValue("@MinfoID", depotData.MInfoID);
            cmd.Parameters.AddWithValue("@Quantity", depotData.Quantity);
            cmd.Parameters.AddWithValue("@Hint", depotData.Hint);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 删除库存管理信息
        /// </summary>
        /// <param name="depotData">库存管理类</param>
        /// <returns></returns>
        public int delDepot(DepotData depotData)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from depot where id = @ID", conn);
            cmd.Parameters.AddWithValue("@ID",depotData.ID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 更新库存管理信息
        /// </summary>
        /// <param name="depotData">库存管理类</param>
        /// <returns></returns>
        public int updateDepot(DepotData depotData)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update depot set MinfoID = @MinfoID,Quantity = @Quantity,Hint = @Hint where ID = @id", conn);
            cmd.Parameters.AddWithValue("id",depotData.ID);
            cmd.Parameters.AddWithValue("@MinfoID", depotData.MInfoID);
            cmd.Parameters.AddWithValue("@Quantity", depotData.Quantity);
            cmd.Parameters.AddWithValue("@Hint", depotData.Hint);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 查询库存管理信息
        /// </summary>
        /// <param name="depotData">库存管理类</param>
        /// <returns>返回库存管理类</returns>
        public List<DepotData> selDepot()
        {
            DepotData depotData = new DepotData();
            List<DepotData> list = new List<DepotData>();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from depot",conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                depotData.ID = (int)dr[0];
                depotData.MInfoID = (int)dr[1];
                depotData.Quantity = (int)dr[2];
                depotData.Hint = (int)dr[3];
                list.Add(depotData);
            }
            return list;
        }
    }
}
