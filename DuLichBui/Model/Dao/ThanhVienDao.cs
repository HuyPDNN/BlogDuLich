using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class ThanhVienDao
    {
        DulichBuiDbContext db = null;
        public ThanhVienDao()
        {
            db = new DulichBuiDbContext();
        }
        public ThanhVien chitiet(long id)
        {
            return db.ThanhVien.Find(id);
        }
    }
}
