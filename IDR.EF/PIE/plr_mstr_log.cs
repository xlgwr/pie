namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class plr_mstr_log
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Batch_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Wec_Ctn { get; set; }

        public int CartonNo { get; set; }

        [StringLength(50)]
        public string plr_wec_ctn { get; set; }

        [Required]
        [StringLength(50)]
        public string CartonID { get; set; }

        [StringLength(50)]
        public string CartonType { get; set; }

        [StringLength(30)]
        public string packingListID { get; set; }

        [StringLength(30)]
        public string InvoiceID { get; set; }

        [StringLength(50)]
        public string plr_site { get; set; }

        [StringLength(10)]
        public string plr_pallet_no { get; set; }

        [StringLength(30)]
        public string plr_po { get; set; }

        [StringLength(50)]
        public string plr_co { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string plr_partno { get; set; }

        [StringLength(50)]
        public string plr_date_code { get; set; }

        [StringLength(30)]
        public string plr_vend_mfgr { get; set; }

        [StringLength(30)]
        public string Plr_vm_partno { get; set; }

        public decimal? plr_qty { get; set; }

        public DateTime? plr_rcp_date { get; set; }

        public DateTime? plr_deli_date { get; set; }

        [StringLength(50)]
        public string carton_id_prifix { get; set; }

        [StringLength(10)]
        public string plr_status { get; set; }

        public DateTime? plr_cre_date { get; set; }

        [StringLength(50)]
        public string plr_cre_userid { get; set; }

        public DateTime? plr_update_date { get; set; }

        [StringLength(50)]
        public string plr_edituser_id { get; set; }

        [StringLength(50)]
        public string plr_user_ip { get; set; }

        public short? plr_void_status { get; set; }

        [StringLength(50)]
        public string plr_chr01 { get; set; }

        [StringLength(50)]
        public string plr_chr02 { get; set; }

        public int? plr_deci1 { get; set; }

        public decimal? plr_deci2 { get; set; }
    }
}
