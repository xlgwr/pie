using System;
namespace PIE.Model
{
    /// <summary>
    /// vpi_report_palletCount:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class vpi_report_palletCount
    {
        public vpi_report_palletCount()
        { }
        #region Model
        private string _pi_no;
        private int? _plr_lineid;
        private string _pi_carton_no;
        private int? _ttl;
        private string _pi_desc;
        private decimal? _pi_gw;
        private string _use_char01;
        private string _use_char02;
        private int _use_dec01;
        private string _pi_pallet_no;
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
        public int? plr_LineID
        {
            set { _plr_lineid = value; }
            get { return _plr_lineid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PI_CARTON_NO
        {
            set { _pi_carton_no = value; }
            get { return _pi_carton_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? TTL
        {
            set { _ttl = value; }
            get { return _ttl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PI_DESC
        {
            set { _pi_desc = value; }
            get { return _pi_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PI_GW
        {
            set { _pi_gw = value; }
            get { return _pi_gw; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string use_char01
        {
            set { _use_char01 = value; }
            get { return _use_char01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string use_char02
        {
            set { _use_char02 = value; }
            get { return _use_char02; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int use_dec01
        {
            set { _use_dec01 = value; }
            get { return _use_dec01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_pallet_no
        {
            set { _pi_pallet_no = value; }
            get { return _pi_pallet_no; }
        }
        #endregion Model

    }
}

