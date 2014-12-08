namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("codetable")]
    public partial class codetable
    {
        [Key]
        [StringLength(1)]
        public string gb { get; set; }

        [StringLength(1)]
        public string big { get; set; }
    }
}
