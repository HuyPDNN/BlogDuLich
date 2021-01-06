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
        public ThanhVien GetById(string taiKhoan)
        {
            return db.ThanhVien.SingleOrDefault(o => o.TaiKhoan == taiKhoan);
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
