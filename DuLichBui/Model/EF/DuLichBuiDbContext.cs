namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DuLichBuiDbContext : DbContext
    {
        public DuLichBuiDbContext()
            : base("name=DuLichBuiDbContext")
        {
        }

        public virtual DbSet<BinhLuanBaiViet> BinhLuanBaiViet { get; set; }
        public virtual DbSet<DanhGiaBaiViet> DanhGiaBaiViet { get; set; }
        public virtual DbSet<LoaiThanhVien> LoaiThanhVien { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThanhVien> ThanhVien { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }
        public virtual DbSet<TinTuc> TinTuc { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinhLuanBaiViet>()
                .Property(e => e.MaBinhLuan)
                .IsUnicode(false);

            modelBuilder.Entity<BinhLuanBaiViet>()
                .Property(e => e.MaTinTuc)
                .IsUnicode(false);

            modelBuilder.Entity<BinhLuanBaiViet>()
                .Property(e => e.MaThanhVien)
                .IsUnicode(false);

            modelBuilder.Entity<DanhGiaBaiViet>()
                .Property(e => e.MaDanhGia)
                .IsUnicode(false);

            modelBuilder.Entity<DanhGiaBaiViet>()
                .Property(e => e.MaTinTuc)
                .IsUnicode(false);

            modelBuilder.Entity<DanhGiaBaiViet>()
                .Property(e => e.MaThanhVien)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiThanhVien>()
                .Property(e => e.MaLoaiThanhVien)
                .IsUnicode(false);

            modelBuilder.Entity<Quyen>()
                .Property(e => e.MaQuyen)
                .IsUnicode(false);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.TaiKhoan)
                .WithOptional(e => e.Quyen1)
                .HasForeignKey(e => e.Quyen);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TaiKhoan1)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.AnhDaiDien)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Quyen)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.MaThanhVien)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.MaLoaiThanhVien)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.AnhDaiDien)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.FaceBookLink)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.TongBaiViet)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.TongLuotDanhGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.TienHoaHong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<TinTuc>()
                .Property(e => e.MaTinTuc)
                .IsUnicode(false);

            modelBuilder.Entity<TinTuc>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<TinTuc>()
                .Property(e => e.MaThanhVien)
                .IsUnicode(false);

            modelBuilder.Entity<TinTuc>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<TinTuc>()
                .Property(e => e.Image)
                .IsUnicode(false);
        }
    }
}
