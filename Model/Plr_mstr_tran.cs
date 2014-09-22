using System;
namespace PIE.Model
{
    /// <summary>
    /// plr_mstr_tran:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class plr_mstr_tran
    {
        public plr_mstr_tran()
        { }
        #region Model
        private string _batch_id;
        private int _lineid;
        private int _wec_ctn;
        private string _plr_status;
        private string _plr_status_msg;
        private string _cartonno;
        private string _cartonid;
        private string _plr_wec_ctn;
        private string _plr_po;
        private string _plr_partno;
        private string _cartontype;
        private decimal? _plr_carton_qty;
        private decimal? _plr_qty;
        private string _plr_suppliers_id;
        private string _packinglistid;
        private string _invoiceid;
        private DateTime? _plr_rcp_date;
        private string _plr_pallet_no;
        private DateTime? _plr_deli_date;
        private string _plr_site;
        private string _plr_co;
        private string _plr_date_code;
        private string _plr_vend_mfgr;
        private string _plr_vm_partno;
        private string _carton_id_prifix;
        private string _re_mark;
        private DateTime? _plr_cre_date;
        private string _plr_cre_userid;
        private DateTime? _plr_update_date;
        private string _plr_edituser_id;
        private string _plr_user_ip;
        private int? _plr_void_status;
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
        public int Wec_Ctn
        {
            set { _wec_ctn = value; }
            get { return _wec_ctn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_status
        {
            set { _plr_status = value; }
            get { return _plr_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_status_msg
        {
            set { _plr_status_msg = value; }
            get { return _plr_status_msg; }
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
        public string plr_wec_ctn
        {
            set { _plr_wec_ctn = value; }
            get { return _plr_wec_ctn; }
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
        public string CartonType
        {
            set { _cartontype = value; }
            get { return _cartontype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? plr_carton_qty
        {
            set { _plr_carton_qty = value; }
            get { return _plr_carton_qty; }
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
        public string plr_suppliers_id
        {
            set { _plr_suppliers_id = value; }
            get { return _plr_suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string packingListID
        {
            set { _packinglistid = value; }
            get { return _packinglistid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceID
        {
            set { _invoiceid = value; }
            get { return _invoiceid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? plr_rcp_date
        {
            set { _plr_rcp_date = value; }
            get { return _plr_rcp_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_pallet_no
        {
            set { _plr_pallet_no = value; }
            get { return _plr_pallet_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? plr_deli_date
        {
            set { _plr_deli_date = value; }
            get { return _plr_deli_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_site
        {
            set { _plr_site = value; }
            get { return _plr_site; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_co
        {
            set { _plr_co = value; }
            get { return _plr_co; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_date_code
        {
            set { _plr_date_code = value; }
            get { return _plr_date_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_vend_mfgr
        {
            set { _plr_vend_mfgr = value; }
            get { return _plr_vend_mfgr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plr_vm_partno
        {
            set { _plr_vm_partno = value; }
            get { return _plr_vm_partno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string carton_id_prifix
        {
            set { _carton_id_prifix = value; }
            get { return _carton_id_prifix; }
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

