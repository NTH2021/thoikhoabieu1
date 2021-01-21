namespace TKB.DATATKB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string TenTaiKhoan { get; set; }

        [StringLength(20)]
        public string PASS { get; set; }

        [StringLength(20)]
        public string MaGiaoVien { get; set; }

        [StringLength(10)]
        public string QUYEN { get; set; }
    }
}
