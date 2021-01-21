namespace TKB.DATATKB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TKB")]
    public partial class TKB
    {
        [Key]
        [StringLength(20)]
        public string SoTiet { get; set; }

        [Column("Thứ 2")]
        [StringLength(50)]
        public string Thứ_2 { get; set; }

        [Column("Thứ 3")]
        [StringLength(50)]
        public string Thứ_3 { get; set; }

        [Column("Thứ 4")]
        [StringLength(50)]
        public string Thứ_4 { get; set; }

        [Column("Thứ 5")]
        [StringLength(50)]
        public string Thứ_5 { get; set; }

        [Column("Thứ 6")]
        [StringLength(50)]
        public string Thứ_6 { get; set; }

        [Column("Thứ 7")]
        [StringLength(50)]
        public string Thứ_7 { get; set; }

        [Column("Chủ Nhật")]
        [StringLength(50)]
        public string Chủ_Nhật { get; set; }

        [StringLength(20)]
        public string MaGiangDay { get; set; }
    }
}
