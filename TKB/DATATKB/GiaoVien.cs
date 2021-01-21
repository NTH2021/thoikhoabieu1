namespace TKB.DATATKB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        [Key]
        [StringLength(20)]
        public string MaGiaoVien { get; set; }

        [StringLength(50)]
        public string TenGiaoVien { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public int? SDT { get; set; }
    }
}
