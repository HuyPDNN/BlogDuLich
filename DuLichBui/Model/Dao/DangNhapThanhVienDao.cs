using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class DangNhapThanhVienDao
    {
        DulichBuiDbContext db = null;
        public DangNhapThanhVienDao()
        {
            db = new DulichBuiDbContext();
        }
        public IEnumerable<ThanhVien> ListInfoThanhVien()
        {
            return db.ThanhVien.ToList();
        }
        public ThanhVien GetById(string taiKhoan)
        {
            return db.ThanhVien.SingleOrDefault(o => o.TaiKhoan == taiKhoan);
        }
        //public ThanhVien ViewDetail(string mathanhvien)
        //{
        //    return db.ThanhVien.Find(mathanhvien);
        //}
        public ThanhVien ViewDetail(int mathanhvien)
        {
            return db.ThanhVien.SingleOrDefault(o=> o.MaThanhVien == mathanhvien);

        }
        //public bool CapNhatThongTinThanhVien(ThanhVien entity)
        //{
        //    try
        //    {
        //        var user = db.ThanhVien.Find(entity.MaThanhVien);
        //        user.HoTen = entity.HoTen;
        //        user.GioiTinh = entity.GioiTinh;
        //        user.NgaySinh = entity.NgaySinh;
        //        user.SDT = entity.SDT;
        //        user.DiaChi = entity.DiaChi;
        //        user.ThanhPho = entity.ThanhPho;
        //        user.QuocGia = entity.QuocGia;
        //        user.MoTaBanThan = entity.MoTaBanThan;
        //        user.MatKhau = entity.MatKhau;
        //        user.FaceBookLink = entity.FaceBookLink;
        //        user.AnhDaiDien = entity.AnhDaiDien;
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        public int DangNhapThanhVien(string taikhoan, string matkhau)
        {
            var result = db.ThanhVien.SingleOrDefault(o => o.TaiKhoan == taikhoan);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.TrangThai == false)
                {
                    return -1;
                }
                else
                {
                    if (result.MatKhau == matkhau)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
        }
    }
}
