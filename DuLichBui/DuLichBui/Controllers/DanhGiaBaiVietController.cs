using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuLichBui.Controllers
{
    public class DanhGiaBaiVietController : Controller
    {
        // GET: DanhGiaBaiViet
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult DanhGia(int id)
        {
            var result = new BaiVietDao().Danhgia(id);
            return Json(new
            {
                danhgia = result
            });
        }
    }
}