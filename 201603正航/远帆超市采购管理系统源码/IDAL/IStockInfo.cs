using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IStockInfo
    {
        /// <summary>
        /// 插入采购明细单
        /// </summary>
        /// <param name="stockInfo">采购明细单类</param>
        /// <returns></returns>
        int insertStockInfo(StockInfoData stockInfo);
        /// <summary>
        /// 删除采购明细单
        /// </summary>
        /// <param name="stockInfo">采购明细单类</param>
        /// <returns></returns>
        int delStockInfo(StockInfoData stockInfo);
        /// <summary>
        /// 更新采购明细单
        /// </summary>
        /// <param name="stockInfo">采购明细单类</param>
        /// <returns></returns>
        int updateStockInfo(StockInfoData stockInfo);
        /// <summary>
        /// 查询采购明细单
        /// </summary>
        /// <param name="stockInfo">采购明细单类</param>
        /// <returns></returns>
        List<StockInfoData> selStockInfo(StockData sd);
    }
}
