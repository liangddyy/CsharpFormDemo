using System;


namespace model
{
    /// <summary>
    /// User数据实体结构
    /// <summary>
    [Serializable]
    public class UserData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_NAME = "name";
        public const string FIELD_PWD = "pwd";
        public const string FIELD_PURVIEW = "purview";
        #endregion

        #region 私有变量

        private int _iD;
        private string _name;
        private string _pwd;
        private int _purview;
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
        /// 字段pwd实体
        /// <summary>
        public string Pwd
        {
            get { return this._pwd; }
            set { this._pwd = value; }
        }

        /// <summary>
        /// 字段purview实体
        /// <summary>
        public int Purview
        {
            get { return this._purview; }
            set { this._purview = value; }
        }

        #endregion
    }
}
