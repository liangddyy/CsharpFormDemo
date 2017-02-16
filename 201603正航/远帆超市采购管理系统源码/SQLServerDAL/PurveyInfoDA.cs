using System;
using System.Collections.Generic;
using System.Text;
using model;
using IDAL;
using System.Data;
using System.Data.SqlClient;
namespace SQLServerDAL
{
    public class PurveyInfoDA:IDAL.IPurveyInfo
    {
        static string connStr = UserDA.connStr;
        /// <summary>
        /// 插入供应商信息
        /// </summary>
        /// <param name="purvey">供应商信息类</param>
        /// <returns></returns>
        public int insertPurvey(PurveyInfoData purveyInfo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into purveyInfo values(@name,@PTypeID,@LinkMan,@Tel,@Fox,@Address,@Email,@Days)", conn);
            cmd.Parameters.AddWithValue("@name", purveyInfo.Name);
            cmd.Parameters.AddWithValue("@PTypeID", purveyInfo.PTypeID);
            cmd.Parameters.AddWithValue("@LinkMan", purveyInfo.LinkMan);
            cmd.Parameters.AddWithValue("@Tel", purveyInfo.Tel);
            cmd.Parameters.AddWithValue("@Fox", purveyInfo.Fox);
            cmd.Parameters.AddWithValue("@Address", purveyInfo.Address);
            cmd.Parameters.AddWithValue("@Email", purveyInfo.Email);
            cmd.Parameters.AddWithValue("@Days", purveyInfo.Days);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
        }
        /// <summary>
        /// 删除供应商信息
        /// </summary>
        /// <param name="purvey">供应商信息类</param>
        /// <returns></returns>
        public int delPurvey(PurveyInfoData purveyInfo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from purveyInfo where id = @id", conn);
            cmd.Parameters.AddWithValue("@id",purveyInfo.ID);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 修改供应商信息
        /// </summary>
        /// <param name="purvey">供应商信息类</param>
        /// <returns></returns>
        public int updatePurvey(PurveyInfoData purveyInfo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update purveyInfo set name = @name,PTypeID = @PTypeID,LinkMan = @LinkMan,Tel= @Tel,Fox = @Fox,Address = @Address,Email=@Email,Days=@Days where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", purveyInfo.ID);
            cmd.Parameters.AddWithValue("@name", purveyInfo.Name);
            cmd.Parameters.AddWithValue("@PTypeID", purveyInfo.PTypeID);
            cmd.Parameters.AddWithValue("@LinkMan", purveyInfo.LinkMan);
            cmd.Parameters.AddWithValue("@Tel", purveyInfo.Tel);
            cmd.Parameters.AddWithValue("@Fox", purveyInfo.Fox);
            cmd.Parameters.AddWithValue("@Address", purveyInfo.Address);
            cmd.Parameters.AddWithValue("@Email", purveyInfo.Email);
            cmd.Parameters.AddWithValue("@Days", purveyInfo.Days);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        /// <summary>
        /// 查询供应商信息
        /// </summary>
        /// <param name="purvey">供应商信息类</param>
        /// <returns>返回供应商信息集合</returns>
        public List<PurveyInfoData> selPurvey()
        {
            List<PurveyInfoData> list = new List<PurveyInfoData>();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from purveyInfo",conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                PurveyInfoData pur = new PurveyInfoData();
                pur.ID = (int)dr[0];
                pur.Name = dr[1].ToString();
                pur.PTypeID = (int)dr[2];
                pur.LinkMan = dr[3].ToString();
                pur.Tel = dr[4].ToString();
                pur.Fox = dr[5].ToString();
                pur.Address = dr[6].ToString();
                pur.Email = dr[7].ToString();
                pur.Days = (int)dr[8];
                list.Add(pur);
            }
            return list;
        }
    }
}
