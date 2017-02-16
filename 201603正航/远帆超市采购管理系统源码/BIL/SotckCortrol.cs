using System;
using System.Collections.Generic;
using System.Text;
using IDAL;
using SQLServerDAL;
using model;

namespace BIL
{
    public class SotckCortrol
    {
        private static IStock st = Factory.getStock();
        private static IStockInfo si = Factory.getSInfo();
        public static List<StockData> getStocks()
        {
            return st.selStock();
        }

        /// <summary>
        /// 获取定单头
        /// </summary>
        /// <param name="dt">日期</param>
        /// <param name="state">定单状态 0 未审批 1 审批 2 作废</param>
        /// <returns></returns>
        public static List<StockData> getStocks(DateTime dt,int state)
        {
            string str=string.Empty;
            if (state == 0)
                str = "Down = 0 and StockDate = '" + dt.ToString("d") + "' and Blank = 0";
            else if (state == 1)
                str = "Down = 1 and DownDate = '" + dt.ToString("d") + "' and Blank = 0";
            else if (state == 2)
                str = "Blank = 1";
            return st.selStock(str);
        }
        /// <summary>
        /// 获取定单头
        /// </summary>
        /// <param name="dt">启始日期</param>
        /// <param name="dt1">结束日期</param>
        /// <param name="state">定单状态 0 未审批 1 审批 2 作废</param>
        /// <returns></returns>
        public static List<StockData> getStocks(DateTime dt, DateTime dt1, int state)
        {
            string str = string.Empty;
            if (state == 0)
                str = "Down = 0 and StockDate between '" + dt.ToString("d") + "' and '" + dt1.ToString("d") + "' and Blank = 0";
            else if (state == 1)
                str = "Down = 1 and DownDate between '" + dt.ToString("d") + "' and '" + dt1.ToString("d") + "' and Blank = 0";
            else if (state == 2)
                str = "Blank = 1";
            return st.selStock(str);
        }
        /// <summary>
        /// 获取所有定单头
        /// </summary>
        /// <param name="state">定单状态 0 未审批 1 审批 2 作废</param>
        /// <returns></returns>
        public static List<StockData> getStocks( int state)
        {
            string str = string.Empty;
            if (state == 0)
                str = "Down = 0 and Blank = 0";
            else if (state == 1)
                str = "Down = 1 and Blank = 0";
            else if (state == 2)
                str = "Blank = 1";
            return st.selStock(str);
        }

        /// <summary>
        /// 根据供应商获取订单头
        /// </summary>
        /// <param name="state">定单状态 0 未审批 1 审批 2 作废</param>
        /// <returns></returns>
        public static List<StockData> getStocks(PurveyInfoData pid)
        {
            string str = string.Empty;
            str="PInfoID = " + pid.ID.ToString();
            return st.selStock(str);
        }

        /// <summary>
        /// 增加订单
        /// </summary>
        /// <param name="sd">订单头</param>
        /// <param name="sidLS">订单信息</param>
        public static void addStock(StockData sd, List<StockInfoData> sidLS)
        {
            st.insertStock(sd, sidLS);
        }
        /// <summary>
        /// 审批采购单
        /// </summary>
        /// <param name="sd">订单头</param>
        public static void downStock(StockData sd)
        {
            st.downStock( sd);
        }

        /// <summary>
        /// 作废采购单
        /// </summary>
        /// <param name="sd">订单头</param>
        public static void blankStock(StockData sd)
        {
            st.BlankStock(sd);
        }
        public static List<StockInfoData> getStockInfo(StockData sd)
        {
            return si.selStockInfo(sd);
        }
    }
}
