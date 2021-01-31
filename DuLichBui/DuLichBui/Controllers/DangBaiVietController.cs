using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
using DuLichBui.Common;

namespace DuLichBui.Controllers
{
    public class DangBaiVietController : Controller
    {

        // GET: ThanhVien
        public BaiVietDao dao = new BaiVietDao();
        public DulichBuiDbContext db = new DulichBuiDbContext();
        public ActionResult Index(int id,int page = 1, int pagesize = 10)
        {
            var model = dao.DanhSachBVTV(page, pagesize, id);
            return View(model);
        }

        public ActionResult ChiTiet(int id)
        {
            var baiviet = new BaiVietDao().Chitiet(id);
            //ViewBag.thanhvien = new ThanhVienDao().chitiet(baiviet.MaThanhVien.Value);
            return View(baiviet);
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
            //ViewBag.thanhvien = new ThanhVienDao().chitiet(id);
            return View();
        }
        [HttpPost]
        public ActionResult ThemBaiViet(BaiViet model)
        {

            var bv = new TaiKhoanLogin();
            if (ModelState.IsValid)
            {
                long mabaiviet = dao.Insert(model);
                if (mabaiviet > 0)
                {

                    return RedirectToAction("Index" + "/" + model.MaThanhVien, "DangBaiViet");
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