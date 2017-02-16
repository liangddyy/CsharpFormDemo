using System;


namespace Model
{
    /// <summary>
    /// StockNo数据实体结构
    /// <summary>
    [Serializable]
    public class StockNoData
    {
        #region 常量
        public const string FIELD_NUMBER = "number";
        #endregion

        #region 私有变量

        private int _number;
        #endregion

        #region 公共变量

        /// <summary>
        /// 字段number实体
        /// <summary>
        public int Number
        {
            get { return this._number; }
            set { this._number = value; }
        }

        #endregion
    }
}
