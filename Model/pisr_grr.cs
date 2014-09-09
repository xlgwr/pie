using System;
namespace PI.Model
{
    /// <summary>
    /// pisr_grr:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class pisr_grr
    {
        public pisr_grr()
        { }
        #region Model
        private string _pi_wec_ctn;
        private int _plr_lineid_tran;
        private string _plant="0";
        private string _pisr_rir;
        private string _pisr_invoice;
        private string _pisr_part;
        private string _pisr_receiver;
        private string _pisr_site;
        private string _pisr_po_nbr;
        private decimal? _pisr_qty;
        private string _pisr_curr;
        private decimal? _pisr_cost;
        private decimal? _pisr_base_cost;
        private decimal? _pisr_us_cost;
        private string _pisr_seq;
        private string _pisr_con_code;
        private string _pisr_ch_desc;
        private decimal? _pisr_net_wt;
        private string _pisr_rec_type;
        private string _pisr_abc;
        private string _pisr_code;
        private string _pisr_lic_req;
        private string _pisr_sbu;
        private string _pisr_vend;
        private string _pisr_mfgr_name;
        private string _pisr_char01;
        private string _pisr_char02;
        private string _pisr_char03;
        private decimal? _pisr_dec01;
        private decimal? _pisr_dec02;
        private int? _pisr_int01;
        private int? _pisr_int02;
        private string _pi_status;
        private string _pi_status_msg;
        private string _pi_remark;
        private DateTime? _pi_cre_date;
        private string _pi_cre_userid;
        private DateTime? _pi_update_date;
        private string _pi_edituser_id;
        private string _pi_user_ip;
        private int? _pi_void_status;
        private string _pi_chr01;
        private string _pi_chr02;
        private int? _pi_deci1;
        private decimal? _pi_deci2;
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
        public string Plant
        {
            set { _plant = value; }
            get { return _plant; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_rir
        {
            set { _pisr_rir = value; }
            get { return _pisr_rir; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_invoice
        {
            set { _pisr_invoice = value; }
            get { return _pisr_invoice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_part
        {
            set { _pisr_part = value; }
            get { return _pisr_part; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pisr_receiver
        {
            set { _pisr_receiver = value; }
            get { return _pisr_receiver; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_site
        {
            set { _pisr_site = value; }
            get { return _pisr_site; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_po_nbr
        {
            set { _pisr_po_nbr = value; }
            get { return _pisr_po_nbr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_qty
        {
            set { _pisr_qty = value; }
            get { return _pisr_qty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_curr
        {
            set { _pisr_curr = value; }
            get { return _pisr_curr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_cost
        {
            set { _pisr_cost = value; }
            get { return _pisr_cost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_base_cost
        {
            set { _pisr_base_cost = value; }
            get { return _pisr_base_cost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_us_cost
        {
            set { _pisr_us_cost = value; }
            get { return _pisr_us_cost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_seq
        {
            set { _pisr_seq = value; }
            get { return _pisr_seq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_con_code
        {
            set { _pisr_con_code = value; }
            get { return _pisr_con_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_ch_desc
        {
            set { _pisr_ch_desc = value; }
            get { return _pisr_ch_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_net_wt
        {
            set { _pisr_net_wt = value; }
            get { return _pisr_net_wt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_rec_type
        {
            set { _pisr_rec_type = value; }
            get { return _pisr_rec_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_abc
        {
            set { _pisr_abc = value; }
            get { return _pisr_abc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_code
        {
            set { _pisr_code = value; }
            get { return _pisr_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_lic_req
        {
            set { _pisr_lic_req = value; }
            get { return _pisr_lic_req; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_sbu
        {
            set { _pisr_sbu = value; }
            get { return _pisr_sbu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_vend
        {
            set { _pisr_vend = value; }
            get { return _pisr_vend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_mfgr_name
        {
            set { _pisr_mfgr_name = value; }
            get { return _pisr_mfgr_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_char01
        {
            set { _pisr_char01 = value; }
            get { return _pisr_char01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_char02
        {
            set { _pisr_char02 = value; }
            get { return _pisr_char02; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_char03
        {
            set { _pisr_char03 = value; }
            get { return _pisr_char03; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_dec01
        {
            set { _pisr_dec01 = value; }
            get { return _pisr_dec01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_dec02
        {
            set { _pisr_dec02 = value; }
            get { return _pisr_dec02; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pisr_int01
        {
            set { _pisr_int01 = value; }
            get { return _pisr_int01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pisr_int02
        {
            set { _pisr_int02 = value; }
            get { return _pisr_int02; }
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
        public int? pi_deci1
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

