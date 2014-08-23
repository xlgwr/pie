using System;
namespace PIE.Model
{
    /// <summary>
    /// plr_mstr_err:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class plr_mstr_err
    {
        public plr_mstr_err()
        { }
        #region Model
        private string _batch_id;
        private int _lineid;
        private string _plr_doc_type;
        private string _plr_po;
        private string _plr_partno;
        private decimal? _plr_qty;
        private string _plr_err_msg;
        private DateTime? _plr_cre_date;
        private string _plr_cre_userid;
        private DateTime? _plr_update_date;
        private string _plr_edituser_id;
        private string _plr_user_ip;
        private int? _plr_void_status = 1;
        private string _plr_chr01;
        private string _plr_chr02;
        private int? _plr_deci1;
        private decimal? _plr_deci2;
        /// <summary>
        /// 
        /// </summary>
        public string Batch_ID
        {
            set { _batch_id = value; }
            get { return _batch_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int LineID
        {
            set { _lineid = value; }
            get { return _lineid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_doc_type
        {
            set { _plr_doc_type = value; }
            get { return _plr_doc_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_po
        {
            set { _plr_po = value; }
            get { return _plr_po; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_partno
        {
            set { _plr_partno = value; }
            get { return _plr_partno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? plr_qty
        {
            set { _plr_qty = value; }
            get { return _plr_qty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_err_msg
        {
            set { _plr_err_msg = value; }
            get { return _plr_err_msg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? plr_cre_date
        {
            set { _plr_cre_date = value; }
            get { return _plr_cre_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_cre_userid
        {
            set { _plr_cre_userid = value; }
            get { return _plr_cre_userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? plr_update_date
        {
            set { _plr_update_date = value; }
            get { return _plr_update_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_edituser_id
        {
            set { _plr_edituser_id = value; }
            get { return _plr_edituser_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_user_ip
        {
            set { _plr_user_ip = value; }
            get { return _plr_user_ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? plr_void_status
        {
            set { _plr_void_status = value; }
            get { return _plr_void_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_chr01
        {
            set { _plr_chr01 = value; }
            get { return _plr_chr01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_chr02
        {
            set { _plr_chr02 = value; }
            get { return _plr_chr02; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? plr_deci1
        {
            set { _plr_deci1 = value; }
            get { return _plr_deci1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? plr_deci2
        {
            set { _plr_deci2 = value; }
            get { return _plr_deci2; }
        }
        #endregion Model

    }
}

