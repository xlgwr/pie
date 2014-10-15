using System;
namespace PI.Model
{
    /// <summary>
    /// PI_MSTR_Remote:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PI_MSTR_Remote
    {
        public PI_MSTR_Remote()
        { }
        #region Model
        private string _pi_no;
        private DateTime? _pi_date;
        private string _pi_page;
        private DateTime _msrepl_synctran_ts;
        /// <summary>
        /// 
        /// </summary>
        public string PI_NO
        {
            set { _pi_no = value; }
            get { return _pi_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PI_Date
        {
            set { _pi_date = value; }
            get { return _pi_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PI_Page
        {
            set { _pi_page = value; }
            get { return _pi_page; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime msrepl_synctran_ts
        {
            set { _msrepl_synctran_ts = value; }
            get { return _msrepl_synctran_ts; }
        }
        #endregion Model

    }
}

