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
        public ActionResult Index()
        {
            var model = dao.DanhSachBaiViet().ToList();
            return View(model);
        }
    }
}