namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhGiaBaiViet")]
    public partial class DanhGiaBaiViet
    {
        [Key]
        [StringLength(50)]
        public string MaDanhGia { get; set; }

        [StringLength(50)]
        public string MaTinTuc { get; set; }

        [StringLength(50)]
        public string MaThanhVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDanhGia { get; set; }

        public int? DanhGiaSao { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }

        public virtual TinTuc TinTuc { get; set; }
    }
}
