using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IMerchandiseType
    {
        /// <summary>
        /// 插入商品类别
        /// </summary>
        /// <param name="merType">商品类别类</param>
        /// <returns></returns>
        int insertMerchandiseType(MerchandiseTypeData merType);
        /// <summary>
        /// 删除商品类别
        /// </summary>
        /// <param name="merType">商品类别类</param>
        /// <returns></returns>
        int delMerchandiseType(MerchandiseTypeData merType);
        /// <summary>
        /// 修改商品类别
        /// </summary>
        /// <param name="merType">商品类别类</param>
        /// <returns></returns>
        int updateMerchandiseType(MerchandiseTypeData merType);
        /// <summary>
        /// 查询商品类别
        /// </summary>
        /// <param name="merType">商品类别类</param>
        /// <returns>返回商品类别的集合</returns>
        List<MerchandiseTypeData> selMerchandiseType();
    }
}
