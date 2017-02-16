using System;
using System.Collections.Generic;
using System.Text;
using model;
using SQLServerDAL;
using IDAL;

namespace BIL
{
    public class PInfoCortrol
    {

        private static IPurveyInfo pi = Factory.getPInfo();
        public static List<PurveyInfoData> ls = getPurveyInfoData();
        public static List<PurveyInfoData> getPurveyInfoData()
        {
           return pi.selPurvey();
        }
        /// <summary>
        /// 增加供应商,且返回新增加记录的ID
        /// </summary>
        /// <param name="pid"></param>
        /// <returns>新增加的ID</returns>
        public static int addPurveyInfo(PurveyInfoData pid)
        {
            int i = pi.insertPurvey(pid);
            pid.ID=i;
            ls.Add(pid);
            return i;
        }
        
        /// <summary>
        /// 修改供应商信息
        /// </summary>
        /// <param name="mtd">欲修改的类</param>
        /// <returns>返回所处集合的ID，对应ListView的项目位置</returns>
        public static int updPurveyInfo(PurveyInfoData pid)
        {
            pi.updatePurvey(pid);
            int i;
            for (i = 0; i < ls.Count; i++)
            {
                if (pid.ID == ls[i].ID)
                {
                    ls[i] = pid;
                    break;
                }
            }
            return i;
        }

        /// <summary>
        /// 删除供应商信息
        /// </summary>
        /// <param name="ptd">欲删除的类</param>
        public static void delPurveyInfo(PurveyInfoData pid)
        {
            pi.delPurvey(pid);
            int i;
            for (i = 0; i < ls.Count; i++)
            {
                if (pid.ID == ls[i].ID)
                {
                    ls.RemoveAt(i);
                    break;
                }
            }
        }

        /// <summary>
        /// 根据类型ID取得类
        /// </summary>
        /// <param name="id">类型ID</param>
        /// <returns></returns>
        public static PurveyInfoData getPInfoOfID(int id)
        {
            foreach (PurveyInfoData pdd in ls)
                if (pdd.ID == id)
                    return pdd;
            throw new MessageException("获取客户信息失败！客户ID" + id);
        }
    }
}
