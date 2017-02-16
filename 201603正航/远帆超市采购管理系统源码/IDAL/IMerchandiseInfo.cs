using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IMerchandiseInfo
    {
        /// <summary>
        /// 插入商品信息
        /// </summary>
        /// <param name="merType">商品信息类</param>
        /// <returns></returns>
        int insertMerchandiseType(MerchandiseInfoData merInfo);
        /// <summary>
        /// 删除商品信息
        /// </summary>
        /// <param name="merType">商品信息类</param>
        /// <returns></returns>
        int delMerchandiseType(MerchandiseInfoData merInfo);
        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="merType">商品信息类</param>
        /// <returns></returns>
        int updateMerchandiseType(MerchandiseInfoData merInfo);
        /// <summary>
        /// 查询商品信息
        /// </summary>
        /// <param name="merType">商品信息类</param>
        /// <returns>返回商品信息的集合</returns>
        List<MerchandiseInfoData> selMerchandiseType();
    }
}
