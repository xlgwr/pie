using System;
namespace PI.Model
{
    /// <summary>
    /// codetable:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class codetable
    {
        public codetable()
        { }
        #region Model
        private string _gb;
        private string _big;
        /// <summary>
        /// 
        /// </summary>
        public string gb
        {
            set { _gb = value; }
            get { return _gb; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string big
        {
            set { _big = value; }
            get { return _big; }
        }
        #endregion Model

    }
}

