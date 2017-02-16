using System;
using System.Collections.Generic;
using System.Text;
using SQLServerDAL;
using IDAL;

namespace BIL
{
    /// <summary>
    /// 工厂类，用于实例化数据库操作
    /// </summary>
    public static class Factory
    {
        public static IUser getUser()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new UserDA();
                default:
                    throw new DBException();
            }
        }


        public static IMerchandiseInfo getMInfo()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new MerchandiseInfoDA();
                default:
                    throw new DBException();
            }
        }



        public static IMerchandiseType getMType()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new MerchandiseTypeDA();
                default:
                    throw new DBException();
            }
        }

        public static IPurveyInfo getPInfo()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new PurveyInfoDA();
                default:
                    throw new DBException();
            }
        }

        public static IPurveyType getPType()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new PurveyTypeDA();
                default:
                    throw new DBException();
            }
        }

        public static IPurvey getPurvey()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new PurveyDA();
                default:
                    throw new DBException();
            }
        }

        public static IStock getStock()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new StockDA();
                default:
                    throw new DBException();
            }
        }

        public static IStockInfo getSInfo()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new StockInfoDA();
                default:
                    throw new DBException();
            }
        }

        public static IStockNo getStockNO()
        {
            switch (Set.set.DBType)
            {
                case Set.SqlServer:
                    return new StockNoDA();
                default:
                    throw new DBException();
            }
        } 
    }
}
