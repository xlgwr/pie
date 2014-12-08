namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vplr_carton
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Batch_ID { get; set; }

        [StringLength(50)]
        public string plr_wec_ctn { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineID { get; set; }

        [StringLength(10)]
        public string plr_pallet_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CartonNo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CartonID { get; set; }

        [StringLength(50)]
        public string plr_co { get; set; }

        [StringLength(30)]
        public string plr_po { get; set; }
    }
}
