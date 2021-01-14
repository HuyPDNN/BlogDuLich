using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class BinhLuanDanhGiaDao
    {

        DulichBuiDbContext db = null;
        public BinhLuanDanhGiaDao()
        {
            db = new DulichBuiDbContext();
        }
        public long Insert(BinhLuanBaiViet bl)
        {
            db.BinhLuanBaiViet.Add(bl);
            db.SaveChanges();
            return bl.MaBinhLuan;
        }
        public List<BinhLuanBaiViet> ListBL()
        {
            return db.BinhLuanBaiViet.OrderByDescending(o => o.NgayBinhLuan).ToList(); ;
        }
    }
}
