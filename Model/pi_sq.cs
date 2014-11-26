using System;
namespace PI.Model
{
    /// <summary>
    /// pi_sq:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class pi_sq
    {
        public pi_sq()
        { }
        #region Model
        private string _sq_type;
        private int _sq_id;
        private string _sq_name;
        private string _sq_desc;
        private string _sq_unit;
        private string _co_id;
        private string _co_desc;
        /// <summary>
        /// 
        /// </summary>
        public string sq_type
        {
            set { _sq_type = value; }
            get { return _sq_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sq_id
        {
            set { _sq_id = value; }
            get { return _sq_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sq_name
        {
            set { _sq_name = value; }
            get { return _sq_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sq_desc
        {
            set { _sq_desc = value; }
            get { return _sq_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sq_unit
        {
            set { _sq_unit = value; }
            get { return _sq_unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string co_id
        {
            set { _co_id = value; }
            get { return _co_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string co_desc
        {
            set { _co_desc = value; }
            get { return _co_desc; }
        }
        #endregion Model

    }
}

