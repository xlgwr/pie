namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pkey_ctl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string t_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string t_value { get; set; }

        [StringLength(4000)]
        public string t_desc { get; set; }

        [StringLength(50)]
        public string t_yyww { get; set; }

        [StringLength(50)]
        public string prefix { get; set; }

        public decimal? ctl_fro { get; set; }

        public decimal? ctl_to { get; set; }

        public decimal? ctl_curr { get; set; }

        public decimal? ctl_curr_len { get; set; }

        public decimal? ctl_len { get; set; }
    }
}
