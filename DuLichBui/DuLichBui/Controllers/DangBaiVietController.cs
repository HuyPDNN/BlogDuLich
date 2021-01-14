using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace DuLichBui.Controllers
{
    public class DangBaiVietController : Controller
    {
        // GET: ThanhVien
        public BaiVietDao dao = new BaiVietDao();
        public ActionResult Index(int page = 1 , int pagesize = 10)
        {
            var model = dao.DanhSachBaiViet(page,pagesize);
            return View(model);
        }
        [HttpGet]
        public ActionResult ThemBaiViet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemBaiViet(BaiViet bv)
        {
            if (ModelState.IsValid)
            {
                long id = dao.Insert(bv);
                if(id >0)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm bài viêt không thành công");
                }
            }
            return View("ThemBaiViet");

        }
    }
}