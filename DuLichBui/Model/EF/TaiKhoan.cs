namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string MaTaiKhoan { get; set; }

        [Column("TaiKhoan")]
        [StringLength(50)]
        public string TaiKhoan1 { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public int? SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string AnhDaiDien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKi { get; set; }

        public int? TienLuong { get; set; }

        [StringLength(50)]
        public string Quyen { get; set; }

        public bool? TrangThai { get; set; }

        public virtual Quyen Quyen1 { get; set; }
    }
}
