using System;
using System.Collections.Generic;
using System.Text;
using model;
using SQLServerDAL;
using IDAL;

namespace BIL
{
    public class MInfoCortrol
    {
        private static IMerchandiseInfo mi = Factory.getMInfo();
        public static List<MerchandiseInfoData> ls = MInfoCortrol.getPType();

        public static List<MerchandiseInfoData> getPType()
        {
            return mi.selMerchandiseType();
        }

        /// <summary>
        /// 增加商品,且返回新增加记录的ID
        /// </summary>
        /// <param name="mid"></param>
        /// <returns>新增加的ID</returns>
        public static int addMnfo(MerchandiseInfoData mid)
        {
            int i = mi.insertMerchandiseType(mid);
            mid.ID = i;
            ls.Add(mid);
            return i;
        }

        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="mtd">欲修改的类</param>
        /// <returns>返回所处集合的ID，对应ListView的项目位置</returns>
        public static int updMInfo(MerchandiseInfoData mid)
        {
            mi.updateMerchandiseType(mid);
            int i;
            for (i = 0; i < ls.Count; i++)
            {
                if (mid.ID == ls[i].ID)
                {
                    ls[i] = mid;
                    break;
                }
            }
            return i;
        }

        /// <summary>
        /// 删除商品信息
        /// </summary>
        /// <param name="ptd">欲删除的类</param>
        public static void delMInfo(MerchandiseInfoData mid)
        {
            mi.delMerchandiseType(mid);
            int i;
            for (i = 0; i < ls.Count; i++)
            {
                if (mid.ID == ls[i].ID)
                {
                    ls.RemoveAt(i);
                    break;
                }
            }
        }

        /// <summary>
        /// 根据商品ID取得类型
        /// </summary>
        /// <param name="id">类型ID</param>
        /// <returns></returns>
        public static MerchandiseInfoData getMInfoOfID(int id)
        {
            foreach (MerchandiseInfoData mid in ls)
                if (mid.ID == id)
                    return mid;
            throw new MessageException("获取商品名称失败！商品ID" + id);
        }
    }
}
