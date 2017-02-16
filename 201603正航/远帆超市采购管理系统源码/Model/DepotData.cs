using System;


namespace model
{
    /// <summary>
    /// Depot数据实体结构
    /// <summary>
    [Serializable]
    public class DepotData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_MINFOID = "mInfoID";
        public const string FIELD_QUANTITY = "quantity";
        public const string FIELD_HINT = "hint";
        #endregion

        #region 私有变量

        private int _iD;
        private int _mInfoID;
        private int _quantity;
        private int _hint;
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
        /// 字段mInfoID实体
        /// <summary>
        public int MInfoID
        {
            get { return this._mInfoID; }
            set { this._mInfoID = value; }
        }

        /// <summary>
        /// 字段quantity实体
        /// <summary>
        public int Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        /// <summary>
        /// 字段hint实体
        /// <summary>
        public int Hint
        {
            get { return this._hint; }
            set { this._hint = value; }
        }

        #endregion
    }
}
