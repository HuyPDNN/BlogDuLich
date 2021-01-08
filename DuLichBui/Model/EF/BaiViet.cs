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
        [StringLength(50)]
        public string MaBaiViet { get; set; }

        [StringLength(50)]
        public string MaTheLoai { get; set; }

        [StringLength(50)]
        public string MaThanhVien { get; set; }

        public string TieuDe { get; set; }

        public string MieuTa { get; set; }

        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDang { get; set; }


        public string Link { get; set; }

        public string Image { get; set; }

        public int? TongLuotXem { get; set; }

        public string TrangThai { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }

        public virtual TheLoai TheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuanBaiViet> BinhLuanBaiViet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGiaBaiViet> DanhGiaBaiViet { get; set; }
    }
}
