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
    using Newtonsoft.Json;

    [JsonObject(IsReference = true)]
    public partial class pi_mstr
    {
        public pi_mstr()
        {
            this.pi_det = new HashSet<pi_det>();
        }
    
        public string PI_ID { get; set; }
        public int LineID { get; set; }
        public string Plant { get; set; }
        public string pi_type { get; set; }
        public string pi_status { get; set; }
        public string pi_status_msg { get; set; }
        public string pi_remark { get; set; }
        public Nullable<System.DateTime> pi_cre_date { get; set; }
        public string pi_cre_userid { get; set; }
        public Nullable<System.DateTime> pi_update_date { get; set; }
        public string pi_edituser_id { get; set; }
        public string pi_user_ip { get; set; }
        public Nullable<short> pi_void_status { get; set; }
        public string pi_chr01 { get; set; }
        public string pi_chr02 { get; set; }
        public Nullable<int> pi_deci1 { get; set; }
        public Nullable<decimal> pi_deci2 { get; set; }


        public virtual ICollection<pi_det> pi_det { get; set; }
    }
}
