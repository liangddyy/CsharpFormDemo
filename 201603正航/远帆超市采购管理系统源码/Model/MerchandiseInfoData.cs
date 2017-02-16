using System;


namespace model
{
    /// <summary>
    /// MerchandiseInfo数据实体结构
    /// <summary>
    [Serializable]
    public class MerchandiseInfoData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_NAME = "name";
        public const string FIELD_TYPEID = "typeID";
        public const string FIELD_QUANTITY = "quantity";
        public const string FIELD_STORAGE = "storage";
        #endregion

        #region 私有变量

        private int _iD;
        private string _name;
        private int _typeID;
        private int _quantity;
        private int _storage;
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
        /// 字段typeID实体
        /// <summary>
        public int TypeID
        {
            get { return this._typeID; }
            set { this._typeID = value; }
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
        /// 字段storage实体
        /// <summary>
        public int Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        #endregion
    }
}
