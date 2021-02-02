using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;

namespace Model.AdminModel
{
    public class DuyetBaiDao
    {
        DulichBuiDbContext db = null; 
        public DuyetBaiDao()
        {
            db = new DulichBuiDbContext();

        }
        public BaiViet Chitiet(long id)
        {
            return db.BaiViet.Find(id);
        }
        public bool duyetBaiViet(int id)
        {
            var baiviet = db.BaiViet.Find(id);
            baiviet.TrangThai = !baiviet.TrangThai;
            db.SaveChanges();
            return baiviet.TrangThai;
        }
        public IEnumerable<BaiViet> DanhSachBaiViet(int page, int pagesize)
        {
            return db.BaiViet.OrderByDescending(o => o.NgayDang).ToPagedList(page, pagesize);
        }
        //public bool DuyetBaiViet(BaiViet entity)
        //{
        //    try
        //    {
        //        var baiviet = db.BaiViet.Find(entity.MaBaiViet);
        //        baiviet.TrangThai = entity.TrangThai;
        //        db.SaveChanges();
        //        return true;
        //    } catch(Exception ex)
        //    {
        //        return false;
        //    }

        //}
    }
}
