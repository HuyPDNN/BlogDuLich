using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;

namespace DuLichBui.Controllers
{
    public class ChiTietBaiVietController : Controller
    {
        // GET: Baiviet
        public ActionResult Index(int id)
        {
            ViewBag.ListBL = new BinhLuanDanhGiaDao().ListBL(id);
            var baiviet = new BaiVietDao().Chitiet(id);
            return View(baiviet);

        }
    }
}