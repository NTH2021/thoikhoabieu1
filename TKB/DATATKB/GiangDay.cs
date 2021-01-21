namespace TKB.DATATKB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiangDay")]
    public partial class GiangDay
    {
        [Key]
        [StringLength(20)]
        public string MaGiangDay { get; set; }

        [StringLength(20)]
        public string MaGiaoVien { get; set; }

        [StringLength(20)]
        public string MaLop { get; set; }

        [StringLength(20)]
        public string MaMon { get; set; }

        public TimeSpan? BatDauGiangDay { get; set; }

        public TimeSpan? KetThucGiangDay { get; set; }
    }
}
