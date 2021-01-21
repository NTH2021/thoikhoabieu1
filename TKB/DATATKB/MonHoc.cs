namespace TKB.DATATKB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [Key]
        [StringLength(20)]
        public string MaMonHoc { get; set; }

        [StringLength(50)]
        public string TenMonHoc { get; set; }

        [StringLength(20)]
        public string SoTiet { get; set; }
    }
}
