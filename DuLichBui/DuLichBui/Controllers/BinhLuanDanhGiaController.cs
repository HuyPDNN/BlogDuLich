using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
namespace DuLichBui.Controllers
{
    public class BinhLuanDanhGiaController : Controller
    {
        // GET: BinhLuanDanhGia
        public BinhLuanDanhGiaDao dao = new BinhLuanDanhGiaDao();
        public ActionResult Index(int id)
        {
            ViewBag.ListBL = new BinhLuanDanhGiaDao().ListBL(id);
            return View();
        }
        [HttpGet]
        public ActionResult ThemBL(long id)
        {
            ViewBag.baiviet = new BaiVietDao().Chitiet(id);
            return View();
        }
        [HttpPost]
        public ActionResult ThemBL(BinhLuanBaiViet bl)
        {
            if (ModelState.IsValid)
            {
                long mabaiviet = dao.Insert(bl);
                if (mabaiviet > 0)
                {
                    return RedirectToAction("Index" + "/" + bl.MaBaiViet, "ChiTietBaiViet");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm bình luận không thành công");
                }
            }
            return View("ThemBL");
        }
    }
}