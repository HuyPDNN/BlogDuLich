using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.AdminModel;

namespace DuLichBui.Areas.Admin.Controllers
{
    public class DuyetBaiController : Controller
    {
        // GET: Admin/DuyetBai
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DuyetBai(int id)
        {
            var bv = new DuyetBaiDao().Chitiet(id);
            return View(bv);
        }
        [HttpPost]
        public JsonResult DuyetBaiViet(int id)
        {
            var result = new DuyetBaiDao().duyetBaiViet(id);
            return Json(new
            {
                status = result
            });
        }
        //[HttpPost]
        //public ActionResult DuyetBai(BaiViet bv)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var baiviet = new DuyetBaiDao().DuyetBaiViet(bv);
        //        if (baiviet)
        //        {
        //            return RedirectToAction("Index", "BaiViet");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Lỗi duyệt bài");

        //        }
        //    }
        //    return View("Index");
        //}


    }
}