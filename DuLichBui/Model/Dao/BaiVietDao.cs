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
        public String ThemBaiViet(BaiViet entity)
        {
            db.BaiViet.Add(entity);
            db.SaveChanges();
            return entity.MaBaiViet;
        }
        public IEnumerable<BaiViet> DanhSachBaiViet(int page, int pageSize )
        {
            return db.BaiViet.OrderBy(o => o.NgayDang).ToPagedList(page, pageSize);
        }
        //public int TrangThaiBaiViet(string baiviet)
        //{
        //    var result = db.BaiViet.SingleOrDefault(o => o.MaBaiViet == baiviet);
        //    if (result.TrangThai == "Lưu Nháp")
        //    {
        //        return 0;
        //    }
        //    else if (result.TrangThai == "Chờ Phê Duyệt")
        //    {
        //        return 1;
        //    }
        //    else if(result.TrangThai == "Đã Xuất Bản")
        //    {
        //        return 2;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}
    }
}

