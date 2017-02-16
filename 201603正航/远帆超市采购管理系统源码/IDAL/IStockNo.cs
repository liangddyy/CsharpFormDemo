using System;
using System.Collections.Generic;
using System.Text;

namespace IDAL
{
    public interface IStockNo
    {
        /// <summary>
        /// ÐÞ¸Ä±àºÅ
        /// </summary>
        /// <param name="user">ÐÂµÄ±àºÅ</param>
        void updateNo(int No);
        
        /// <summary>
        /// ²éÑ¯±àºÅ
        /// </summary>
        /// <returns>±àºÅ</returns>
        int selNo();

    }
}
