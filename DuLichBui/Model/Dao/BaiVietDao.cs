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
            //var ma = id.MaThanhVien.GetType();
            //var tv = db.ThanhVien.Find(id.MaThanhVien);
            var tv = db.ThanhVien.First();
           // var tv = db.ThanhVien.Find(entity.ThanhVien.MaThanhVien);
            db.BaiViet.Add(entity);
            entity.MaThanhVien = tv.MaThanhVien;
            entity.NgayDang = DateTime.Now;
            db.SaveChanges();
            return entity.MaBaiViet;
        }
        public IEnumerable<BaiViet> DanhSachBaiViet(int page, int pagesize)
        {
            return db.BaiViet.Where(o => o.TrangThai == true).OrderByDescending(o => o.NgayDang).ToPagedList(page,pagesize);
        }

        public IEnumerable<BaiViet> DanhSachBVTV(int page, int pagesize, int id)
        {
            var tv = db.ThanhVien.Find(id);
            return db.BaiViet.Where(o => o.MaThanhVien == tv.MaThanhVien).OrderByDescending(o => o.NgayDang).ThenBy(o => o.MaBaiViet).ToPagedList(page, pagesize);
        }
        public BaiViet Chitiet(long id)
        {
            return db.BaiViet.Find(id);
        }
    }
}

