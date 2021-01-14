namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DulichBuiDbContext : DbContext
    {
        public DulichBuiDbContext()
            : base("name=DulichBuiDbContext")
        {
        }

        public virtual DbSet<BaiViet> BaiViet { get; set; }
        public virtual DbSet<BinhLuanBaiViet> BinhLuanBaiViet { get; set; }
        public virtual DbSet<DanhGiaBaiViet> DanhGiaBaiViet { get; set; }
        public virtual DbSet<LoaiThanhVien> LoaiThanhVien { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThanhVien> ThanhVien { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiViet>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<BaiViet>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.TaiKhoan)
                .WithOptional(e => e.Quyen1)
                .HasForeignKey(e => e.Quyen);

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
        }
    }
}
