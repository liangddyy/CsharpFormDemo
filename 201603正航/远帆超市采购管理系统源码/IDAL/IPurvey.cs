using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IPurvey
    {
        /// <summary>
        /// 插入供应商品
        /// </summary>
        /// <param name="purvey">供应商品类</param>
        /// <returns></returns>
        int insertPurvey(PurveyData purvey);
        /// <summary>
        /// 删除供应商品
        /// </summary>
        /// <param name="purvey">供应商品类</param>
        /// <returns></returns>
        int delPurvey(PurveyData purvey);
        /// <summary>
        /// 修改供应商品
        /// </summary>
        /// <param name="purvey">供应商品类</param>
        /// <returns></returns>
        int updatePurvey(PurveyData purvey);
        /// <summary>
        /// 查询供应商品
        /// </summary>
        /// <param name="purvey">供应商品类</param>
        /// <returns>返回供应商品集合</returns>
        List<PurveyData> selPurvey();
    }
}
