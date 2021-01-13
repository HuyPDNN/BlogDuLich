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
        public IEnumerable<TheLoai> DSTheLoai()
        {
            return db.TheLoai.ToList();
        }
        public List<LoaiThanhVien> DSLoaiThanhVien()
        {
            return db.LoaiThanhVien.ToList();
        }
    }
}
