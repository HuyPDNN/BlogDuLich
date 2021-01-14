using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace DuLichBui.Areas.Admin.Controllers
{
    public class NhanVienController : Controller
    {
        DulichBuiDbContext db = null;
        // GET: Admin/NhanVien
        public TaiKhoanDao dao = new TaiKhoanDao();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DanhSachTaiKhoan(int page = 1, int pagesize = 10)
        {
            var model = dao.danhsach(page, pagesize);
            return View(model);
        }
        public ActionResult ThemNhanVien(TaiKhoan taikhoan)
        {
            if (ModelState.IsValid)
            {
                var dao = new TaiKhoanDao();
                long manhanvien = dao.Insert(taikhoan);
                if (manhanvien > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm user không thành công.");
                }
            }
            return View("ThemThanhVien");
        }
    }
}