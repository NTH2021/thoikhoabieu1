namespace TKB.DATATKB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lop")]
    public partial class Lop
    {
        [Key]
        [StringLength(20)]
        public string MaLop { get; set; }

        [StringLength(50)]
        public string TenLop { get; set; }

        public int? SiSo { get; set; }
    }
}
