namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            BaiViet = new HashSet<BaiViet>();
            BinhLuanBaiViet = new HashSet<BinhLuanBaiViet>();
            DanhGiaBaiViet = new HashSet<DanhGiaBaiViet>();
        }

        [Key]
        public int MaThanhVien { get; set; }

        public int? MaLoaiThanhVien { get; set; }

        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        public string HoTen { get; set; }

        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string AnhDaiDien { get; set; }

        public int? SDT { get; set; }

        [StringLength(50)]
        public string QuocGia { get; set; }

        [StringLength(50)]
        public string ThanhPho { get; set; }

        public string DiaChi { get; set; }

        public string FaceBookLink { get; set; }

        public string MoTaBanThan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKi { get; set; }

        public decimal? TongBaiViet { get; set; }

        public decimal? TongLuotDanhGia { get; set; }

        public int? TongLuotXem { get; set; }

        public decimal? TienHoaHong { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiViet> BaiViet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuanBaiViet> BinhLuanBaiViet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGiaBaiViet> DanhGiaBaiViet { get; set; }

        public virtual LoaiThanhVien LoaiThanhVien { get; set; }
    }
}
