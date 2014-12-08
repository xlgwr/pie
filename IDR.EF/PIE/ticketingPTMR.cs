namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ticketingPTMR")]
    public partial class ticketingPTMR
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string t_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string t_suppliers_id { get; set; }

        public DateTime? t_inDocTime { get; set; }

        public DateTime? t_backTime { get; set; }

        [StringLength(50)]
        public string t_outWait { get; set; }

        public DateTime? t_receTime { get; set; }

        public DateTime? t_outAwayTime { get; set; }

        public DateTime? t_waitTime { get; set; }

        public DateTime? t_totalTime { get; set; }

        public DateTime? t_time01 { get; set; }

        public DateTime? t_time02 { get; set; }

        public DateTime? t_cre_date { get; set; }

        public DateTime? t_update_date { get; set; }

        [StringLength(50)]
        public string t_cre_user { get; set; }

        [StringLength(50)]
        public string t_user_ip { get; set; }

        [StringLength(50)]
        public string t_chr01 { get; set; }

        [StringLength(50)]
        public string t_chr02 { get; set; }

        [StringLength(50)]
        public string t_chr03 { get; set; }

        public decimal? t_dec01 { get; set; }

        public decimal? t_dec02 { get; set; }

        public int? t_int01 { get; set; }

        public int? t_int02 { get; set; }
    }
}
