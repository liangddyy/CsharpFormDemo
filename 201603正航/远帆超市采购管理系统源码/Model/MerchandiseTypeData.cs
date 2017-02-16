using System;


namespace model
{
    /// <summary>
    /// MerchandiseType数据实体结构
    /// <summary>
    [Serializable]
    public class MerchandiseTypeData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_NAME = "name";
        public const string FIELD_PARENTID = "parentID";
        #endregion

        #region 私有变量

        private int _iD;
        private string _name;
        private int _parentID;
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
        /// 字段parentID实体
        /// <summary>
        public int ParentID
        {
            get { return this._parentID; }
            set { this._parentID = value; }
        }

        #endregion
    }
}
