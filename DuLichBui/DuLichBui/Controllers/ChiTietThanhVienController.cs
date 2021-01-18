using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace DuLichBui.Controllers
{
    public class ChiTietThanhVienController : Controller
    {
        // GET: TacGia
        public ActionResult Index(long id)
        {
           
                var tacgia = new ThanhVienDao().chitiet(id);
                return View(tacgia);
        }

    }
}