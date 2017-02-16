using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IPurveyInfo
    {
        /// <summary>
        /// 插入供应商信息
        /// </summary>
        /// <param name="purvey">供应商信息类</param>
        /// <returns></returns>
        int insertPurvey(PurveyInfoData purveyInfo);
        /// <summary>
        /// 删除供应商信息
        /// </summary>
        /// <param name="purvey">供应商信息类</param>
        /// <returns></returns>
        int delPurvey(PurveyInfoData purveyInfo);
        /// <summary>
        /// 修改供应商信息
        /// </summary>
        /// <param name="purvey">供应商信息类</param>
        /// <returns></returns>
        int updatePurvey(PurveyInfoData purveyInfo);
        /// <summary>
        /// 查询供应商信息
        /// </summary>
        /// <param name="purvey">供应商信息类</param>
        /// <returns>返回供应商信息集合</returns>
        List<PurveyInfoData> selPurvey();
    }
}
