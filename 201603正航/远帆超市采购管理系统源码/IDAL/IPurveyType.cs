using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IPurveyType
    {
        /// <summary>
        /// 插入供应商类型
        /// </summary>
        /// <param name="purveyType">返回供应商类型类</param>
        /// <returns></returns>
        int insertPurveyType(PurveyTypeData purveyType);
        /// <summary>
        /// 删除供应商类型
        /// </summary>
        /// <param name="purveyType">返回供应商类型类</param>
        /// <returns></returns>
        int delPurveyType(PurveyTypeData purveyType);
        /// <summary>
        /// 更新供应商类型
        /// </summary>
        /// <param name="purveyType">返回供应商类型类</param>
        /// <returns></returns>
        int updatePurveyType(PurveyTypeData purveyType);
        /// <summary>
        /// 查询供应商类型
        /// </summary>
        /// <param name="purveyType">返回供应商类型类</param>
        /// <returns>返回供应商类型的集合</returns>
        List<PurveyTypeData> selPurveyType();
        
    }
}
