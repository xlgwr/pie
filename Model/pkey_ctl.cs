using System;
namespace PIE.Model
{
    /// <summary>
    /// pkey_ctl:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class pkey_ctl
    {
        public pkey_ctl()
        { }
        #region Model
        private string _t_name;
        private string _t_value;
        private string _t_desc;
        private string _t_yyww;
        private string _prefix;
        private decimal? _ctl_fro;
        private decimal? _ctl_to;
        private decimal? _ctl_curr;
        private decimal? _ctl_curr_len;
        private decimal? _ctl_len;
        /// <summary>
        /// 
        /// </summary>
        public string t_name
        {
            set { _t_name = value; }
            get { return _t_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string t_value
        {
            set { _t_value = value; }
            get { return _t_value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string t_desc
        {
            set { _t_desc = value; }
            get { return _t_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string t_yyww
        {
            set { _t_yyww = value; }
            get { return _t_yyww; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string prefix
        {
            set { _prefix = value; }
            get { return _prefix; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ctl_fro
        {
            set { _ctl_fro = value; }
            get { return _ctl_fro; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ctl_to
        {
            set { _ctl_to = value; }
            get { return _ctl_to; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ctl_curr
        {
            set { _ctl_curr = value; }
            get { return _ctl_curr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ctl_curr_len
        {
            set { _ctl_curr_len = value; }
            get { return _ctl_curr_len; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ctl_len
        {
            set { _ctl_len = value; }
            get { return _ctl_len; }
        }
        #endregion Model

    }
}

