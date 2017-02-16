using System;
using System.Collections.Generic;
using System.Text;
using IDAL;
using model;
using SQLServerDAL;

namespace BIL
{
    public class StockNoCortrol
    {
        private static IStockNo sn = Factory.getStockNO();

        private static int _no;

        public static int No
        {
            get
            {
                _no = sn.selNo();
                return _no;
            }
            set
            {
                _no = value;
                sn.updateNo(value);
            }
        }
        
    }
}
