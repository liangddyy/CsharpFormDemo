using System;


namespace model
{
    /// <summary>
    /// PurveyType数据实体结构
    /// <summary>
    [Serializable]
    public class PurveyTypeData
    {
        #region 常量
        public const string FIELD_ID = "iD";
        public const string FIELD_TYPENAME = "typeName";
        #endregion

        #region 私有变量

        private int _iD;
        private string _typeName;
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
        /// 字段typeName实体
        /// <summary>
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        #endregion
        public PurveyTypeData() { }

        public PurveyTypeData(int id, string typeName)
        {
            this._iD = id;
            this._typeName = typeName;
        }
        public override string ToString()
        {
            return this._typeName;
        }
    }
}
//５/１/a/ｓ/ｐ/ｘ