using DuLichBui.Common;
using DuLichBui.Models;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuLichBui.Controllers
{
    public class DangNhapThanhVienController : Controller
    {
        // GET: DangNhapThanhVien
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult DangNhap(DangNhapThanhVienModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new DangNhapThanhVienDao();
                var result = dao.DangNhapThanhVien(model.Taikhoan, model.Matkhau);
                if (result == 1)
                {
                    var taikhoan = dao.GetById(model.Taikhoan);
                    var taikhoanSession = new TaiKhoanLogin();
                    taikhoanSession.TaiKhoan = taikhoan.TaiKhoan;
                    taikhoanSession.TaiKhoanID = taikhoan.MaThanhVien;
                    Session.Add(CommonConstants.USER_SESSION, taikhoanSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài Khoản đang bị khóa");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng");
                }
            }
            return View("Index");
        }
        public ActionResult Logout()
        {
            Session[CommonConstants.USER_SESSION] = null;
            return Redirect("/");
        }
        public ActionResult ThongTinChiTietThanhVien(string mathanhvien)
        {
            var thanhvien = new DangNhapThanhVienDao();
            ViewBag.loaithanhvien = new TheLoaiDao().DSLoaiThanhVien();
            return View(thanhvien);
        }
    }
}