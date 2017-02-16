using System;
using System.Collections.Generic;
using System.Text;
using model;
using SQLServerDAL;
using IDAL;

namespace BIL
{
    public class PTypeCortrol
    {
        private static IPurveyType pt = Factory.getPType();
        public static List<PurveyTypeData> ls = PTypeCortrol.getPType();

        public static List<PurveyTypeData> getPType()
        {
            return pt.selPurveyType();
        }
        /// <summary>
        /// 增加类型名并返回新ID
        /// </summary>
        /// <param name="ptd">增加的类</param>
        /// <returns>新ID</returns>
        public static int addTypeName(PurveyTypeData ptd)
        {
            int i = pt.insertPurveyType(ptd);
            ptd.ID = i;
            ls.Add(ptd);
            return i;
        }

        /// <summary>
        /// 修改类型名并返回所处集合的下标
        /// </summary>
        /// <param name="ptd"><增加的类/param>
        /// <returns>所处集合的下标</returns>
        public static int updTypeName(PurveyTypeData ptd)
        {
            pt.updatePurveyType(ptd);
            int i;
            for (i = 0; i < ls.Count; i++)
            {
                if (ptd.ID == ls[i].ID)
                {
                    ls[i] = ptd;
                    break;
                }
            }
            return i;
        }

        /// <summary>
        /// 删除类型名并返回所处集合的下标
        /// </summary>
        /// <param name="ptd"><增加的类/param>
        /// <returns>所处集合的下标</returns>
        public static int delTypeName(PurveyTypeData ptd)
        {
            pt.delPurveyType(ptd);
            int i;
            for (i = 0; i < ls.Count; i++)
            {
                if (ptd.ID == ls[i].ID)
                {
                    ls.RemoveAt(i);
                    break;
                }
            }
            return i;
        }
        /// <summary>
        /// 根据类型ID取得类型名
        /// </summary>
        /// <param name="id">类型ID</param>
        /// <returns></returns>
        public static PurveyTypeData getPTypeOfID(int id)
        {
            foreach (PurveyTypeData ptd in ls)
                if (ptd.ID == id)
                    return ptd;
            throw new MessageException("获取客户类型失败！类型ID"+id);
        }
    }
}
