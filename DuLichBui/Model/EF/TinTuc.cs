namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinTuc()
        {
            BinhLuanBaiViet = new HashSet<BinhLuanBaiViet>();
            DanhGiaBaiViet = new HashSet<DanhGiaBaiViet>();
        }

        [Key]
        [StringLength(50)]
        public string MaTinTuc { get; set; }

        [StringLength(50)]
        public string MaTheLoai { get; set; }

        [StringLength(50)]
        public string MaThanhVien { get; set; }

        public string TieuDe { get; set; }

        public string MieuTa { get; set; }

        public string NoiDung { get; set; }

        public string TacGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDang { get; set; }

        public string TuKhoa { get; set; }

        public string Link { get; set; }

        public string Image { get; set; }

        public int? TongLuotXem { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuanBaiViet> BinhLuanBaiViet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGiaBaiViet> DanhGiaBaiViet { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
