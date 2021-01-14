using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace DuLichBui.Areas.Admin.Controllers
{
    public class BaiVietController : Controller
    {
        public BaiVietDao dao = new BaiVietDao();
        // GET: Admin/BaiViet
        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            var model = dao.DanhSachBaiViet(page, pagesize);
            return View(model);
        }
    }
}