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
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    [JsonObject(IsReference = true)]
    public partial class pkey_ctl
    {
        public string t_name { get; set; }
        public string t_value { get; set; }
        public string t_desc { get; set; }
        public string t_yyww { get; set; }
        public string prefix { get; set; }
        public Nullable<decimal> ctl_fro { get; set; }
        public Nullable<decimal> ctl_to { get; set; }
        public Nullable<decimal> ctl_curr { get; set; }
        public Nullable<decimal> ctl_curr_len { get; set; }
        public Nullable<decimal> ctl_len { get; set; }
    }
}
