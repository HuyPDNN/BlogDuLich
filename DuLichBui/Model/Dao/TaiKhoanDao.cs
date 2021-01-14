using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;

namespace Model.Dao
{
    public class TaiKhoanDao
    {
        DulichBuiDbContext db = null;
        public TaiKhoanDao()
        {
            db = new DulichBuiDbContext();
        }
        public IEnumerable<TaiKhoan> danhsach(int page, int pagesize)
        {
            return db.TaiKhoan.OrderByDescending(o => o.NgayDangKi).ToPagedList(page, pagesize);
        }
        public TaiKhoan GetById(string taiKhoan)
        {
            return db.TaiKhoan.SingleOrDefault(o => o.TaiKhoan1 == taiKhoan);
        }
        public long Insert(TaiKhoan taikhoan)
        {
            db.TaiKhoan.Add(taikhoan);
            db.SaveChanges();
            return taikhoan.MaTaiKhoan;
        }
        public int Login(string taikhoan, string matkhau)
        {
            var result = db.TaiKhoan.SingleOrDefault(o => o.TaiKhoan1 == taikhoan);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if(result.TrangThai == false)
                {
                    return -1;
                }
                else
                {
                    if(result.MatKhau == matkhau)
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
