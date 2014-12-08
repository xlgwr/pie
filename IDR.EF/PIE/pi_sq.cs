namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pi_sq
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string sq_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sq_id { get; set; }

        [StringLength(100)]
        public string sq_name { get; set; }

        [StringLength(300)]
        public string sq_desc { get; set; }

        [StringLength(50)]
        public string sq_unit { get; set; }

        [Required]
        [StringLength(50)]
        public string co_id { get; set; }

        [StringLength(50)]
        public string co_desc { get; set; }
    }
}
