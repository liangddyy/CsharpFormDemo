using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IStock
    {
        /// <summary>
        /// 插入采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        int insertStock(StockData stock);
        /// <summary>
        /// 删除采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        int delStock(StockData stock);
        /// <summary>
        /// 更新采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        int updateStock(StockData stock);
        /// <summary>
        /// 查询采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns>返回采购单的集合</returns>
        List<StockData> selStock();

        /// <summary>
        /// 插入订单利用事务
        /// </summary>
        /// <param name="stock">订单头</param>
        /// <param name="ls">订单信息</param>
        /// <returns>返回插入表头id</returns>
        int insertStock(StockData sd, List<StockInfoData> ls);

        /// <summary>
        /// 查询采购单
        /// </summary>
        /// <param name="str">查询条件where部分</param>
        /// <returns></returns>
        List<StockData> selStock(string str);

        /// <summary>
        /// 审批采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        int downStock(StockData stock);

        /// <summary>
        /// 作废采购单
        /// </summary>
        /// <param name="stock">采购单类</param>
        /// <returns></returns>
        int BlankStock(StockData stock);
    }
}
