using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IDepot
    {
        /// <summary>
        /// 插入库存管理信息
        /// </summary>
        /// <param name="depotData">库存管理类</param>
        /// <returns></returns>
        int insertDepot(DepotData depotData);
        /// <summary>
        /// 删除库存管理信息
        /// </summary>
        /// <param name="depotData">库存管理类</param>
        /// <returns></returns>
        int delDepot(DepotData depotData);
        /// <summary>
        /// 更新库存管理信息
        /// </summary>
        /// <param name="depotData">库存管理类</param>
        /// <returns></returns>
        int updateDepot(DepotData depotData);
        /// <summary>
        /// 插入库存管理信息
        /// </summary>
        /// <param name="depotData">库存管理类</param>
        /// <returns>返回库存管理类</returns>
        List<DepotData> selDepot();
    }
}
