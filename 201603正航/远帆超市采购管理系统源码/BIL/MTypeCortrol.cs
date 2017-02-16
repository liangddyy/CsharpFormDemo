using System;
using System.Collections.Generic;
using System.Text;
using model;
using SQLServerDAL;
using IDAL;

namespace BIL
{
    public class MTypeCortrol
    {
        private static IMerchandiseType mt = Factory.getMType();
        public static List<MerchandiseTypeData> ls = MTypeCortrol.getPType();

        public static List<MerchandiseTypeData> getPType()
        {
            return mt.selMerchandiseType();
        }
        /// <summary>
        /// 增加类型
        /// </summary>
        /// <param name="mtd"></param>
        /// <returns>新增加记录的id</returns>
        public static int addTypeName(MerchandiseTypeData mtd)
        {
            int i = mt.insertMerchandiseType(mtd);
            mtd.ID = i;
            ls.Add(mtd);
            return i;
        }

        /// <summary>
        /// 修改类型名
        /// </summary>
        /// <param name="ptd"></param>
        public static void updTypeName(MerchandiseTypeData mtd)
        {
            mt.updateMerchandiseType(mtd);
            int i;
            for (i = 0; i < ls.Count; i++)
            {
                if (mtd.ID == ls[i].ID)
                {
                    ls[i] = mtd;
                    break;
                }
            }
        }

        /// <summary>
        /// 删除类型名
        /// </summary>
        /// <param name="ptd">欲删除的类</param>
        public static void delTypeName(MerchandiseTypeData mtd)
        {
            mt.delMerchandiseType(mtd);
            int i;
            for (i = 0; i < ls.Count; i++)
            {
                if (mtd.ID == ls[i].ID)
                {
                    ls.RemoveAt(i);
                    break;
                }
            }
        }
        /// <summary>
        /// 检查类别下是否有子项
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <returns></returns>
        public static bool checkChild(int id)
        {
            bool ok = false;
            foreach (MerchandiseTypeData mtd in ls)
                if(mtd.ParentID == id)
                {
                    ok = true;
                    break;
                }
            return ok;
        }

        /// <summary>
        /// 根据类型ID取得类型名
        /// </summary>
        /// <param name="id">类型ID</param>
        /// <returns></returns>
        public static MerchandiseTypeData getMTypeOfID(int id)
        {
            foreach (MerchandiseTypeData mtd in ls)
                if (mtd.ID == id)
                    return mtd;
            throw new MessageException("获取商品类型失败！类型ID" + id);
        }
    }
}
