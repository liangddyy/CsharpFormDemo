using System;


namespace model
{
    /// <summary>
    /// PurveyInfo数据实体结构
    /// <summary>
    [Serializable]
    public class PurveyInfoData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_NAME = "name";
        public const string FIELD_PTYPEID = "pTypeID";
        public const string FIELD_LINKMAN = "linkMan";
        public const string FIELD_TEL = "tel";
        public const string FIELD_FOX = "fox";
        public const string FIELD_ADDRESS = "address";
        public const string FIELD_EMAIL = "emial";
        public const string FIELD_DAYS = "days";
        #endregion

        #region 私有变量

        private int _iD;
        private string _name;
        private int _pTypeID;
        private string _linkMan;
        private string _tel;
        private string _fox;
        private string _address;
        private string _email;
        private int _days;
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
        /// 字段name实体
        /// <summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// 字段pTypeID实体
        /// <summary>
        public int PTypeID
        {
            get { return this._pTypeID; }
            set { this._pTypeID = value; }
        }

        /// <summary>
        /// 字段linkMan实体
        /// <summary>
        public string LinkMan
        {
            get { return this._linkMan; }
            set { this._linkMan = value; }
        }

        /// <summary>
        /// 字段tel实体
        /// <summary>
        public string Tel
        {
            get { return this._tel; }
            set { this._tel = value; }
        }

        /// <summary>
        /// 字段fox实体
        /// <summary>
        public string Fox
        {
            get { return this._fox; }
            set { this._fox = value; }
        }

        /// <summary>
        /// 字段address实体
        /// <summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public int Days
        {
            get { return this._days; }
            set { this._days = value; }
        }
        #endregion
    }
}
