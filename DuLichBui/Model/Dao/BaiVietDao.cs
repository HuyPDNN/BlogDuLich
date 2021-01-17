using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class BaiVietDao
    {
        DulichBuiDbContext db = null;
        public BaiVietDao()
        {
            db = new DulichBuiDbContext();
        }
        public long Insert(BaiViet entity)
        {
            db.BaiViet.Add(entity);
            db.SaveChanges();
            return entity.MaBaiViet;
        }
        public IEnumerable<BaiViet> DanhSachBaiViet(int page, int pagesize)
        {
            return db.BaiViet.Where(o => o.TrangThai == true).OrderByDescending(o => o.NgayDang).ToPagedList(page,pagesize);
        }
        public BaiViet Chitiet(long id)
        {
            return db.BaiViet.Find(id);
        }
    }
}

