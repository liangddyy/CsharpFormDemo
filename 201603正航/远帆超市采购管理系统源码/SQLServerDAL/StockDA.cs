using System;
using System.Collections.Generic;
using System.Text;
using model;
using IDAL;
using System.Data;
using System.Data.SqlClient;
namespace SQLServerDAL
{
    public class StockDA:IDAL.IStock
    {
        static string connStr = UserDA.connStr;
        /// <summary>
        /// 插入采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        public int insertStock(StockData stock)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into stock values(@StockNo,@PInfoID,@UserID,@StockDate)", conn);
            cmd.Parameters.AddWithValue("@StockNo", stock.StockNo);
            cmd.Parameters.AddWithValue("@PInfoID", stock.PInfoID);
            cmd.Parameters.AddWithValue("@UserID", stock.UserID);
            cmd.Parameters.AddWithValue("@StockDate", stock.StockDate);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
        }
        /// <summary>
        /// 插入订单利用事务
        /// </summary>
        /// <param name="stock">订单头</param>
        /// <param name="ls">订单信息</param>
        /// <returns>返回插入的表头id</returns>
        public int insertStock(StockData stock, List<StockInfoData> ls)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into stock(StockNo,PInfoID,UserID,StockDate,Down,Blank) values(@StockNo,@PInfoID,@UserID,@StockDate,0,0)", conn);
            SqlTransaction trans;
            trans = conn.BeginTransaction();
            cmd.Transaction = trans;
            List<int> rlist = new List<int>();
           try
            {
                cmd.Parameters.AddWithValue("@StockNo", stock.StockNo);
                cmd.Parameters.AddWithValue("@PInfoID", stock.PInfoID);
                cmd.Parameters.AddWithValue("@UserID", stock.UserID);
                cmd.Parameters.AddWithValue("@StockDate", stock.StockDate);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@IDENTITY";
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (StockInfoData sd in ls)
                {
                    cmd.CommandText = "insert into stockInfo values(@SID,@MID,@Price,@Quantity)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@SID", i);
                    cmd.Parameters.AddWithValue("@MID", sd.MID);
                    cmd.Parameters.AddWithValue("@Price", sd.Price);
                    cmd.Parameters.AddWithValue("@Quantity", sd.Quantity);
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
                return i;
            }
            catch (SqlException ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 删除采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        public int delStock(StockData stock)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete * from stock where id = @id",conn);
            cmd.Parameters.AddWithValue("@id",stock.ID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 更新采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        public int updateStock(StockData stock)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update stock set StockNo = @StockNo,PInfoID = @PInfoID,UserID = @UserID,StockDate = @StockDate,Down = @Down,DownDate = @DownDate,DownUserID = @DownUserID,Blank = @Blank,BlankDate = @BlankDate,BlankUserID = @BlankUserID where id= @id", conn);
            cmd.Parameters.AddWithValue("@id", stock.ID);
            cmd.Parameters.AddWithValue("@StockNo", stock.StockNo);
            cmd.Parameters.AddWithValue("@PInfoID", stock.PInfoID);
            cmd.Parameters.AddWithValue("@UserID", stock.UserID);
            cmd.Parameters.AddWithValue("@StockDate", stock.StockNo);
            cmd.Parameters.AddWithValue("@Down", stock.Down);
            cmd.Parameters.AddWithValue("@DownDate", stock.DownDate);
            cmd.Parameters.AddWithValue("@DownUserID", stock.DownUserID);
            cmd.Parameters.AddWithValue("@Blank", stock.Blank);
            cmd.Parameters.AddWithValue("@BlankDate", stock.BlankDate);
            cmd.Parameters.AddWithValue("@BlankUserID", stock.BlankUserID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        /// <summary>
        /// 审批采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        public int downStock(StockData stock)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update stock set Down = @Down,DownDate = @DownDate,DownUserID = @DownUserID where id= @id", conn);
            cmd.Parameters.AddWithValue("@id", stock.ID);
            cmd.Parameters.AddWithValue("@Down", stock.Down);
            cmd.Parameters.AddWithValue("@DownDate", stock.DownDate);
            cmd.Parameters.AddWithValue("@DownUserID", stock.DownUserID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        /// <summary>
        /// 作废采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        public int BlankStock(StockData stock)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update stock set Blank = @Blank,BlankDate = @BlankDate,BlankUserID = @BlankUserID where id= @id", conn);
            cmd.Parameters.AddWithValue("@id", stock.ID);
            cmd.Parameters.AddWithValue("@Blank", stock.Blank);
            cmd.Parameters.AddWithValue("@BlankDate", stock.BlankDate);
            cmd.Parameters.AddWithValue("@BlankUserID", stock.BlankUserID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        /// <summary>
        /// 查询采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns>返回采购单的集合</returns>
        public List<StockData> selStock()
        {
            List<StockData> list = new List<StockData>();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from stock",conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                StockData stockData = new StockData();
                stockData.ID = (int)dr[0];
                stockData.StockNo = (string)dr[1];
                stockData.PInfoID = (int)dr[2];
                stockData.UserID = (int)dr[3];
                stockData.StockDate = (DateTime)dr[4];
                if ((!(dr[5] is DBNull)) && (bool)dr[5] == true)
                {
                    stockData.Down = (bool)dr[5];
                    stockData.DownDate = Convert.ToDateTime(dr[6]);
                    stockData.DownUserID = Convert.ToInt32(dr[7]);
                }
                if ((!(dr[8] is DBNull)) && (bool)dr[8] == true)
                {
                    stockData.Blank = (bool)dr[8];
                    stockData.BlankDate = Convert.ToDateTime(dr[9]);
                    stockData.BlankUserID = Convert.ToInt32(dr[10]);
                }
                list.Add(stockData);
            }
            return list;
        }

        /// <summary>
        /// 查询采购单
        /// </summary>
        /// <param name="str">查询条件where部分</param>
        /// <returns></returns>
        public List<StockData> selStock(string str)
        {
            List<StockData> list = new List<StockData>();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from stock where "+str, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                StockData stockData = new StockData();
                stockData.ID = (int)dr[0];
                stockData.StockNo = (string)dr[1];
                stockData.PInfoID = (int)dr[2];
                stockData.UserID = (int)dr[3];
                stockData.StockDate = (DateTime)dr[4];
                if ((!(dr[5] is DBNull)) && (bool)dr[5] == true)
                {
                    stockData.Down = (bool)dr[5];
                    stockData.DownDate = Convert.ToDateTime(dr[6]);
                    stockData.DownUserID = Convert.ToInt32(dr[7]);
                }
                if ((!(dr[8] is DBNull)) && (bool)dr[8] == true)
                {
                    stockData.Blank = (bool)dr[8];
                    stockData.BlankDate = Convert.ToDateTime(dr[9]);
                    stockData.BlankUserID = Convert.ToInt32(dr[10]);
                }
                list.Add(stockData);
            }
            return list;
        }
    }
}
