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
        public long DangKiThanhVien(ThanhVien entity)
        {
            db.ThanhVien.Add(entity);
            db.SaveChanges();
            return entity.MaThanhVien;
        }
        public bool CheckTaiKhoan(string taikhoan)
        {
            return db.ThanhVien.Count(x => x.TaiKhoan == taikhoan) > 0;
        }
        public bool CheckEmail(string email)
        {
            return db.ThanhVien.Count(x => x.Email == email) > 0;
        }
        
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
