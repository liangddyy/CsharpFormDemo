using System;


namespace model
{
    /// <summary>
    /// Purvey数据实体结构
    /// <summary>
    [Serializable]
    public class PurveyData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_PINFOID = "pInfoID";
        public const string FIELD_MTYPEID = "mInfoID";
        public const string FIELD_PRICE = "price";
        #endregion

        #region 私有变量

        private int _iD;
        private int _pInfoID;
        private int _mInfoID;
        private double _price;
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
        /// 字段pInfoID实体
        /// <summary>
        public int PInfoID
        {
            get { return this._pInfoID; }
            set { this._pInfoID = value; }
        }

        /// <summary>
        /// 字段mTypeID实体
        /// <summary>
        public int MInfoID
        {
            get { return this._mInfoID; }
            set { this._mInfoID = value; }
        }

        /// <summary>
        /// 字段price实体
        /// <summary>
        public double Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        #endregion
    }
}
//５/1/ａ/ｓ/ｐ/ｘ