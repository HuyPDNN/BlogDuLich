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
        public int MaBinhLuan { get; set; }

        public int? MaBaiViet { get; set; }

        public int? MaThanhVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBinhLuan { get; set; }

        public string NoiDungBinhLuan { get; set; }

        public virtual BaiViet BaiViet { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
