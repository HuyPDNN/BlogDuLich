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
        public int MaDanhGia { get; set; }

        public int? MaBaiViet { get; set; }

        public int? MaThanhVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDanhGia { get; set; }

        public int? DanhGiaSao { get; set; }

        public virtual BaiViet BaiViet { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
