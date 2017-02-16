using System;
using System.Collections.Generic;
using System.Text;
using model;
using IDAL;
using System.Data;
using System.Data.SqlClient;
namespace SQLServerDAL
{
    public class StockInfoDA:IDAL.IStockInfo
    {
        static string connStr = UserDA.connStr;
        /// <summary>
        /// 插入采购明细单
        /// </summary>
        /// <param name="stockInfo">采购明细单类</param>
        /// <returns></returns>
        public int insertStockInfo(StockInfoData stockInfo)
        {
        //    private int _iD;
        //private int _sID;
        //private int _mID;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into stockInfo values(@sID,@mID,@Price,@Quantity)", conn);
            cmd.Parameters.AddWithValue("@sID",stockInfo.SID);
            cmd.Parameters.AddWithValue("@mID",stockInfo.MID);
            cmd.Parameters.AddWithValue("@Price", stockInfo.Price);
            cmd.Parameters.AddWithValue("@Quantity", stockInfo.Quantity);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
        }
        /// <summary>
        /// 删除采购明细单
        /// </summary>
        /// <param name="stockInfo">采购明细单类</param>
        /// <returns></returns>
        public int delStockInfo(StockInfoData stockInfo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from stockInfo where id = @id", conn);
            cmd.Parameters.AddWithValue("@id",stockInfo.ID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 更新采购明细单
        /// </summary>
        /// <param name="stockInfo">采购明细单类</param>
        /// <returns></returns>
        public int updateStockInfo(StockInfoData stockInfo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update stockInfo set sID=@sid,mID = @mID,Price = @Price,Quantity=@Quantity where id = @id", conn);
            cmd.Parameters.AddWithValue("@sID", stockInfo.SID);
            cmd.Parameters.AddWithValue("@mID", stockInfo.MID);
            cmd.Parameters.AddWithValue("@id",stockInfo.ID);
            cmd.Parameters.AddWithValue("@Price", stockInfo.Price);
            cmd.Parameters.AddWithValue("@Quantity", stockInfo.Quantity);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 查询采购明细单
        /// </summary>
        /// <param name="stockInfo">采购明细单类</param>
        /// <returns></returns>
        public List<StockInfoData> selStockInfo(StockData sd)
        {
            List<StockInfoData> list = new List<StockInfoData>();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from stockInfo where SID="+sd.ID.ToString(),conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                StockInfoData stock = new StockInfoData();
                stock.ID = (int)dr[0];
                stock.SID = (int)dr[1];
                stock.MID = (int)dr[2];
                stock.Price = Convert.ToDouble(dr[3]);
                stock.Quantity = (int)dr[4];
                list.Add(stock);
            }
            return list;
        }
    }
}
