namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pisr_grr
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string pi_wec_ctn { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int plr_LineID_tran { get; set; }

        [Required]
        [StringLength(50)]
        public string Plant { get; set; }

        [StringLength(50)]
        public string pisr_rir { get; set; }

        [StringLength(50)]
        public string pisr_invoice { get; set; }

        [StringLength(50)]
        public string pisr_part { get; set; }

        [StringLength(50)]
        public string Pisr_receiver { get; set; }

        [StringLength(50)]
        public string pisr_site { get; set; }

        [StringLength(50)]
        public string pisr_po_nbr { get; set; }

        public decimal? pisr_qty { get; set; }

        [StringLength(50)]
        public string pisr_curr { get; set; }

        public decimal? pisr_cost { get; set; }

        public decimal? pisr_base_cost { get; set; }

        public decimal? pisr_us_cost { get; set; }

        [StringLength(50)]
        public string pisr_seq { get; set; }

        [StringLength(50)]
        public string pisr_con_code { get; set; }

        [StringLength(50)]
        public string pisr_ch_desc { get; set; }

        public decimal? pisr_net_wt { get; set; }

        [StringLength(50)]
        public string pisr_rec_type { get; set; }

        [StringLength(50)]
        public string pisr_abc { get; set; }

        [StringLength(50)]
        public string pisr_code { get; set; }

        [StringLength(50)]
        public string pisr_lic_req { get; set; }

        [StringLength(50)]
        public string pisr_sbu { get; set; }

        [StringLength(50)]
        public string pisr_vend { get; set; }

        [StringLength(50)]
        public string pisr_mfgr_name { get; set; }

        [StringLength(50)]
        public string pisr_char01 { get; set; }

        [StringLength(50)]
        public string pisr_char02 { get; set; }

        [StringLength(50)]
        public string pisr_char03 { get; set; }

        public decimal? pisr_dec01 { get; set; }

        public decimal? pisr_dec02 { get; set; }

        public int? pisr_int01 { get; set; }

        public int? pisr_int02 { get; set; }

        [StringLength(50)]
        public string pi_status { get; set; }

        [StringLength(4000)]
        public string pi_status_msg { get; set; }

        [Column(TypeName = "text")]
        public string pi_remark { get; set; }

        public DateTime? pi_cre_date { get; set; }

        [StringLength(50)]
        public string pi_cre_userid { get; set; }

        public DateTime? pi_update_date { get; set; }

        [StringLength(50)]
        public string pi_edituser_id { get; set; }

        [StringLength(50)]
        public string pi_user_ip { get; set; }

        public short? pi_void_status { get; set; }

        [StringLength(50)]
        public string pi_chr01 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string pi_chr02 { get; set; }

        public int? pi_deci1 { get; set; }

        public decimal? pi_deci2 { get; set; }
    }
}
