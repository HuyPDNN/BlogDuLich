using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class TheLoaiDao
    {
        DulichBuiDbContext db = null;
        public TheLoaiDao()
        {
            db = new DulichBuiDbContext();
        }
        public List<TheLoai> DSTheLoai()
        {
            return db.TheLoai.ToList();
        }
        public LoaiThanhVien ViewDetail(string maloai)
        {
            return db.LoaiThanhVien.Find(maloai);
        }
    }
}
