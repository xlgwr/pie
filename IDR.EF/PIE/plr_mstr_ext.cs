namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class plr_mstr_ext
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Batch_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineID { get; set; }

        [StringLength(50)]
        public string plr_status { get; set; }

        [StringLength(30)]
        public string packingListID { get; set; }

        [StringLength(30)]
        public string InvoiceID { get; set; }
        
        //5 

        [StringLength(10)]
        public string plr_pallet_no { get; set; }

        [StringLength(50)]
        public string CartonType { get; set; }

        [Required]
        [StringLength(50)]
        public string CartonID { get; set; }

        [StringLength(30)]
        public string plr_po { get; set; }
        //5

        [StringLength(50)]
        public string plr_co { get; set; }

        [StringLength(30)]
        public string plr_partno { get; set; }

        [StringLength(50)]
        public string plr_date_code { get; set; }

        [StringLength(30)]
        public string plr_vend_mfgr { get; set; }

        [StringLength(30)]
        public string Plr_vm_partno { get; set; }
        //5

        public decimal? plr_carton_qty { get; set; }

        public decimal? plr_qty { get; set; }

        public DateTime? plr_rcp_date { get; set; }

        public DateTime? plr_deli_date { get; set; }

        [StringLength(50)]
        public string carton_id_prifix { get; set; }

        //5
        [StringLength(50)]
        public string plr_doc_type { get; set; }

        [Column(TypeName = "text")]
        public string re_mark { get; set; }

        [StringLength(50)]
        public string plr_suppliers_id { get; set; }

        public DateTime? plr_cre_date { get; set; }

        [StringLength(50)]
        public string plr_cre_userid { get; set; }

        public DateTime? plr_update_date { get; set; }

        [StringLength(50)]
        public string plr_user_ip { get; set; }
    }
}
