using System;
namespace PIE.Model
{
    /// <summary>
    /// plr_batch_mstr:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class plr_batch_mstr
    {
        public plr_batch_mstr()
        { }
        #region Model
        private string _batch_id;
        private string _plr_suppliers_id;
        private string _batch_doc;
        private string _batch_status;
        private int? _batch_void = 1;
        private DateTime _batch_cre_date = DateTime.Now;
        private DateTime _batch_update_date = DateTime.Now;
        private string _batch_cre_user;
        private string _batch_user_ip;
        private string _batch_chr01;
        private decimal? _batch_dec01;
        /// <summary>
        /// 
        /// </summary>
        public string batch_id
        {
            set { _batch_id = value; }
            get { return _batch_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_suppliers_id
        {
            set { _plr_suppliers_id = value; }
            get { return _plr_suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string batch_doc
        {
            set { _batch_doc = value; }
            get { return _batch_doc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string batch_status
        {
            set { _batch_status = value; }
            get { return _batch_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? batch_void
        {
            set { _batch_void = value; }
            get { return _batch_void; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime batch_cre_date
        {
            set { _batch_cre_date = value; }
            get { return _batch_cre_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime batch_update_date
        {
            set { _batch_update_date = value; }
            get { return _batch_update_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string batch_cre_user
        {
            set { _batch_cre_user = value; }
            get { return _batch_cre_user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string batch_user_ip
        {
            set { _batch_user_ip = value; }
            get { return _batch_user_ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string batch_chr01
        {
            set { _batch_chr01 = value; }
            get { return _batch_chr01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? batch_dec01
        {
            set { _batch_dec01 = value; }
            get { return _batch_dec01; }
        }
        #endregion Model

    }
}

