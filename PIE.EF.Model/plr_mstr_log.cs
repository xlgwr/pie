//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIE.EF.Model.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class plr_mstr_log
    {
        public string Batch_ID { get; set; }
        public int LineID { get; set; }
        public int Wec_Ctn { get; set; }
        public int CartonNo { get; set; }
        public string plr_wec_ctn { get; set; }
        public string CartonID { get; set; }
        public string CartonType { get; set; }
        public string packingListID { get; set; }
        public string InvoiceID { get; set; }
        public string plr_site { get; set; }
        public string plr_pallet_no { get; set; }
        public string plr_po { get; set; }
        public string plr_co { get; set; }
        public string plr_partno { get; set; }
        public string plr_date_code { get; set; }
        public string plr_vend_mfgr { get; set; }
        public string Plr_vm_partno { get; set; }
        public Nullable<decimal> plr_qty { get; set; }
        public Nullable<System.DateTime> plr_rcp_date { get; set; }
        public Nullable<System.DateTime> plr_deli_date { get; set; }
        public string carton_id_prifix { get; set; }
        public string plr_status { get; set; }
        public Nullable<System.DateTime> plr_cre_date { get; set; }
        public string plr_cre_userid { get; set; }
        public Nullable<System.DateTime> plr_update_date { get; set; }
        public string plr_edituser_id { get; set; }
        public string plr_user_ip { get; set; }
        public Nullable<short> plr_void_status { get; set; }
        public string plr_chr01 { get; set; }
        public string plr_chr02 { get; set; }
        public Nullable<int> plr_deci1 { get; set; }
        public Nullable<decimal> plr_deci2 { get; set; }
    }
}
