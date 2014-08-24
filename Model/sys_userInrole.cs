using System;
namespace PIE.Model
{
    /// <summary>
    /// sys_userInrole:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class sys_userInrole
    {
        public sys_userInrole()
        { }
        #region Model
        private string _user_name;
        private int _role_id;
        private DateTime _update_time;
        private DateTime? _create_time;
        private string _create_user_id;
        private string _update_user_id;
        private string _client_ip;
        private string _re_mark;
        private string _flag_status;
        /// <summary>
        /// 
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int role_id
        {
            set { _role_id = value; }
            get { return _role_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime update_time
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? create_time
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string create_user_id
        {
            set { _create_user_id = value; }
            get { return _create_user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string update_user_id
        {
            set { _update_user_id = value; }
            get { return _update_user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string client_ip
        {
            set { _client_ip = value; }
            get { return _client_ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string re_mark
        {
            set { _re_mark = value; }
            get { return _re_mark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string flag_status
        {
            set { _flag_status = value; }
            get { return _flag_status; }
        }
        #endregion Model

    }
}

