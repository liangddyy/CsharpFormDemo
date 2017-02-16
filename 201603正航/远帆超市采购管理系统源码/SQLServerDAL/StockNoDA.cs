using System;
using System.Collections.Generic;
using System.Text;
using IDAL;
using System.Data.SqlClient;

namespace SQLServerDAL
{
    public class StockNoDA : IStockNo
    {
        public static string connStr =UserDA.connStr;
        public void updateNo(int No)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update StockNo set Number = @Number", conn);
            cmd.Parameters.AddWithValue("@Number", No);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int selNo()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from StockNo", conn);
            int No = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return No;
        }
    }
}
