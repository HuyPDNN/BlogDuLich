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
        public DulichBuiDbContext db = new DulichBuiDbContext();
        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            var model = dao.DanhSachBaiViet(page, pagesize);
            return View(model);
        }
        public void SetViewBag(long? selectedID = null)
        {
            var dao = new TheLoaiDao();
            ViewBag.MaTheLoai = new SelectList(dao.DSTheLoai(), "MaTheLoai", "TenTheLoai", selectedID);
        }
        [HttpGet]
        public ActionResult ThemBaiViet()
        {

            List<TheLoai> listtheloai = db.TheLoai.ToList();
            ViewBag.listtheloai = new SelectList(listtheloai, "MaTheLoai", "TenTheLoai");
            return View();
        }
        [HttpPost]
        public ActionResult ThemBaiViet(BaiViet model)
        {


            if (ModelState.IsValid)
            {
                long mabaiviet = dao.Insert(model);
                if (mabaiviet > 0)
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