using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.AdminModel;

namespace DuLichBui.Areas.Admin.Controllers
{
    public class BaiVietController : Controller
    {
        public DuyetBaiDao dao = new DuyetBaiDao();
        // GET: Admin/BaiViet
        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            var model = dao.DanhSachBaiViet(page, pagesize);
            return View(model);
        }
        [HttpPost]
        public JsonResult DuyetBai(int id)
        {
            var result = new DuyetBaiDao().duyetBaiViet(id);
            return Json(new
            {
                status = result
            });
        }
    }
}