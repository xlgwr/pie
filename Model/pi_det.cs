using System;
namespace PI.Model
{
    /// <summary>
    /// pi_det:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class pi_det
    {
        public pi_det()
        { }
        #region Model
        private string _pi_id;
        private int _pi_lineid;
        private string _pi_wec_ctn;
        private int _plr_lineid_tran;
        private string _pi_pallet_no;
        private string _cartonno;
        private string _cartonid;
        private string _pi_type;
        private string _pi_status;
        private string _pi_status_msg;
        private string _pi_remark;
        private DateTime? _pi_cre_date = DateTime.Now;
        private string _pi_cre_userid;
        private DateTime? _pi_update_date = DateTime.Now;
        private string _pi_edituser_id;
        private string _pi_user_ip;
        private int? _pi_void_status;
        private string _pi_chr01;
        private string _pi_chr02;
        private int _pi_deci1;
        private decimal? _pi_deci2;
        /// <summary>
        /// 
        /// </summary>
        public string PI_ID
        {
            set { _pi_id = value; }
            get { return _pi_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int pi_LineID
        {
            set { _pi_lineid = value; }
            get { return _pi_lineid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_wec_ctn
        {
            set { _pi_wec_ctn = value; }
            get { return _pi_wec_ctn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int plr_LineID_tran
        {
            set { _plr_lineid_tran = value; }
            get { return _plr_lineid_tran; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_pallet_no
        {
            set { _pi_pallet_no = value; }
            get { return _pi_pallet_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartonNo
        {
            set { _cartonno = value; }
            get { return _cartonno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartonID
        {
            set { _cartonid = value; }
            get { return _cartonid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_type
        {
            set { _pi_type = value; }
            get { return _pi_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_status
        {
            set { _pi_status = value; }
            get { return _pi_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_status_msg
        {
            set { _pi_status_msg = value; }
            get { return _pi_status_msg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_remark
        {
            set { _pi_remark = value; }
            get { return _pi_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? pi_cre_date
        {
            set { _pi_cre_date = value; }
            get { return _pi_cre_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_cre_userid
        {
            set { _pi_cre_userid = value; }
            get { return _pi_cre_userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? pi_update_date
        {
            set { _pi_update_date = value; }
            get { return _pi_update_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_edituser_id
        {
            set { _pi_edituser_id = value; }
            get { return _pi_edituser_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_user_ip
        {
            set { _pi_user_ip = value; }
            get { return _pi_user_ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pi_void_status
        {
            set { _pi_void_status = value; }
            get { return _pi_void_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_chr01
        {
            set { _pi_chr01 = value; }
            get { return _pi_chr01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_chr02
        {
            set { _pi_chr02 = value; }
            get { return _pi_chr02; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int pi_deci1
        {
            set { _pi_deci1 = value; }
            get { return _pi_deci1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pi_deci2
        {
            set { _pi_deci2 = value; }
            get { return _pi_deci2; }
        }
        #endregion Model

    }
}

