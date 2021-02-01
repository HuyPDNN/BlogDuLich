using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;
using PagedList.Mvc;

namespace Model.Dao
{
    public class BinhLuanDanhGiaDao
    {

        DulichBuiDbContext db = null;
        public BinhLuanDanhGiaDao()
        {
            db = new DulichBuiDbContext();
        }
        public long Insert(BinhLuanBaiViet entity)
        {
            var tv = db.ThanhVien.First();
            var bv = db.BaiViet.First();
            // var tv = db.ThanhVien.Find(entity.ThanhVien.MaThanhVien);
            db.BinhLuanBaiViet.Add(entity);
            entity.MaThanhVien = tv.MaThanhVien;
            entity.MaBaiViet = bv.MaBaiViet;
            entity.NgayBinhLuan = DateTime.Now;
            db.SaveChanges();
            return entity.MaBinhLuan;
        }
        public List<BinhLuanBaiViet> ListBL(int id)
        {
            var baiviet = db.BaiViet.Find(id);
            return db.BinhLuanBaiViet.Where(x => x.MaBaiViet == baiviet.MaBaiViet).OrderByDescending(o => o.NgayBinhLuan).ToList();
        }
    }
}
