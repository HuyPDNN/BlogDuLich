namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiViet()
        {
            BinhLuanBaiViet = new HashSet<BinhLuanBaiViet>();
            DanhGiaBaiViet = new HashSet<DanhGiaBaiViet>();
        }

        [Key]
        public int MaBaiViet { get; set; }

        public int? MaTheLoai { get; set; }

        public int? MaThanhVien { get; set; }

        public string TieuDe { get; set; }

        public string MieuTa { get; set; }

        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDang { get; set; }

        public string Link { get; set; }

        public string Image { get; set; }

        public int? TongLuotXem { get; set; }

        public bool? TrangThai { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }

        public virtual TheLoai TheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuanBaiViet> BinhLuanBaiViet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGiaBaiViet> DanhGiaBaiViet { get; set; }
    }
}
