using System;


namespace model
{
    /// <summary>
    /// StockInfo数据实体结构
    /// <summary>
    [Serializable]
    public class StockInfoData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_SID = "sID";
        public const string FIELD_MID = "mID";
        public const string FIELD_PRICE = "price";
        public const string FIELD_QUANTITY = "quantity";
        #endregion

        #region 私有变量

        private int _iD;
        private int _sID;
        private int _mID;
        private double _price;
        private int _quantity;
        #endregion

        #region 公共变量

        /// <summary>
        /// 字段iD实体
        /// <summary>
        public int ID
        {
            get { return this._iD; }
            set { this._iD = value; }
        }

        /// <summary>
        /// 字段sID实体
        /// <summary>
        public int SID
        {
            get { return this._sID; }
            set { this._sID = value; }
        }

        /// <summary>
        /// 字段mID实体
        /// <summary>
        public int MID
        {
            get { return this._mID; }
            set { this._mID = value; }
        }

        /// <summary>
        /// 字段price实体
        /// <summary>
        public double Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        /// <summary>
        /// 字段quantity实体
        /// <summary>
        public int Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        #endregion
    }
}
