namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vpi_report_base
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string PI_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pi_LineID { get; set; }

        [StringLength(50)]
        public string pi_status { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string pi_wec_ctn { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int plr_LineID_tran { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CartonNo { get; set; }

        [StringLength(51)]
        public string CartonID { get; set; }

        [StringLength(50)]
        public string pi_chr01 { get; set; }

        [StringLength(4000)]
        public string CoDesc { get; set; }

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

        [StringLength(50)]
        public string pisr_us_cost { get; set; }

        public decimal? pisr_base_cost { get; set; }

        public decimal? pisr_cost { get; set; }

        [StringLength(50)]
        public string pisr_seq { get; set; }

        [StringLength(50)]
        public string pisr_con_code { get; set; }

        [StringLength(100)]
        public string sq_name { get; set; }

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
        public string Vend_name { get; set; }

        [StringLength(50)]
        public string MFGR { get; set; }

        [StringLength(50)]
        public string MFGR_Name { get; set; }

        [StringLength(30)]
        public string MFGR_Part { get; set; }

        public decimal? pisr_dec01 { get; set; }

        public decimal? pisr_dec02 { get; set; }

        [StringLength(10)]
        public string Pallet_TTL_NW { get; set; }

        public DateTime? pi_cre_date { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GW { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string REC_NO { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string Contract { get; set; }

        [StringLength(50)]
        public string pi_pallet_no { get; set; }

        [StringLength(50)]
        public string carton_id_prifix { get; set; }

        [StringLength(50)]
        public string CartonID_No { get; set; }
    }
}
