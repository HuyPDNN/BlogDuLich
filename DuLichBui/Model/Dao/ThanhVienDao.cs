using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class ThanhVienDao
    {
        DulichBuiDbContext db = null;
        public ThanhVienDao()
        {
            db = new DulichBuiDbContext();
        }
        public ThanhVien chitiet(long id)
        {
            return db.ThanhVien.Find(id);
        }
        public bool CapNhatThongTinThanhVIen(ThanhVien entity)
        {
            try
            {
                var thanhvien = db.ThanhVien.Find(entity.MaThanhVien);
                thanhvien.HoTen = entity.HoTen;

                if (!string.IsNullOrEmpty(entity.MatKhau))
                {
                    thanhvien.MatKhau = entity.MatKhau;
                }
                thanhvien.AnhDaiDien = entity.AnhDaiDien;
                thanhvien.ThanhPho = entity.ThanhPho;
                thanhvien.FaceBookLink = entity.FaceBookLink;
                thanhvien.GioiTinh = entity.GioiTinh;
                thanhvien.NgaySinh = entity.NgaySinh;
                thanhvien.HoTen = entity.HoTen;
                thanhvien.DiaChi = entity.DiaChi;
                thanhvien.Email = entity.Email;
                thanhvien.SDT = entity.SDT;
                thanhvien.MoTaBanThan = entity.MoTaBanThan;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
