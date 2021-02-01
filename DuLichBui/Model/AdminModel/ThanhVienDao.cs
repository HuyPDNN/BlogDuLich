using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;
using PagedList.Mvc;

namespace Model.AdminModel
{
    public class ThanhVienDao
    {
        DulichBuiDbContext db = null;
        public ThanhVienDao()
        {
            db = new DulichBuiDbContext();
        }
        public IEnumerable<ThanhVien> DanhSachThanhVien(int page, int pagesize)
        {
            return db.ThanhVien.OrderByDescending(o => o.NgayDangKi).ToPagedList(page, pagesize);
        }
    }
}
