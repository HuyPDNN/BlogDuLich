namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BinhLuanBaiViet")]
    public partial class BinhLuanBaiViet
    {
        [Key]
        [StringLength(50)]
        public string MaBinhLuan { get; set; }

        [StringLength(50)]
        public string MaTinTuc { get; set; }

        [StringLength(50)]
        public string MaThanhVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBinhLuan { get; set; }

        public string NoiDungBinhLuan { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }

        public virtual TinTuc TinTuc { get; set; }
    }
}
