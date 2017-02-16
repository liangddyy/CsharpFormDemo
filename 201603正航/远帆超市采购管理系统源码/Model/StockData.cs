using System;


namespace model
{
    /// <summary>
    /// Stock数据实体结构
    /// <summary>
    [Serializable]
    public class StockData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_STOCKNO = "stockNo";
        public const string FIELD_PINFOID = "pInfoID";
        public const string FIELD_USERID = "userID";
        public const string FIELD_STOCKDATE = "stockDate";
        public const string FIELD_DOWN = "down";
        public const string FIELD_DOWNDATE = "downDate";
        public const string FIELD_DOWNUSERID = "downUserID";
        public const string FIELD_BLANK = "blank";
        public const string FIELD_BLANKDATE = "blankDate";
        public const string FIELD_BLANKUSERID = "blankUserID";
        #endregion

        #region 私有变量

        private int _iD;
        private string _stockNo;
        private int _pInfoID;
        private int _userID;
        private DateTime _stockDate;
        private bool _down;
        private DateTime _downDate;
        private int _downUserID;
        private bool _blank;
        private DateTime _blankDate;
        private int _blankUserID;
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
        /// 字段stockNo实体
        /// <summary>
        public string StockNo
        {
            get { return this._stockNo; }
            set { this._stockNo = value; }
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
        /// 字段userID实体
        /// <summary>
        public int UserID
        {
            get { return this._userID; }
            set { this._userID = value; }
        }

        /// <summary>
        /// 字段stockDate实体
        /// <summary>
        public DateTime StockDate
        {
            get { return this._stockDate; }
            set { this._stockDate = value; }
        }

        /// <summary>
        /// 字段down实体
        /// <summary>
        public bool Down
        {
            get { return this._down; }
            set { this._down = value; }
        }

        /// <summary>
        /// 字段downDate实体
        /// <summary>
        public DateTime DownDate
        {
            get { return this._downDate; }
            set { this._downDate = value; }
        }

        /// <summary>
        /// 字段downUserID实体
        /// <summary>
        public int DownUserID
        {
            get { return this._downUserID; }
            set { this._downUserID = value; }
        }

        /// <summary>
        /// 字段blank实体
        /// <summary>
        public bool Blank
        {
            get { return this._blank; }
            set { this._blank = value; }
        }

        /// <summary>
        /// 字段blankDate实体
        /// <summary>
        public DateTime BlankDate
        {
            get { return this._blankDate; }
            set { this._blankDate = value; }
        }

        /// <summary>
        /// 字段blankUserID实体
        /// <summary>
        public int BlankUserID
        {
            get { return this._blankUserID; }
            set { this._blankUserID = value; }
        }

        #endregion
    }
}
