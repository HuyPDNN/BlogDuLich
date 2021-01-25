using DuLichBui.Common;
using DuLichBui.Models;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;


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
                    taikhoanSession.AnhDaiDien = taikhoan.AnhDaiDien;
                    taikhoanSession.HoTen = taikhoan.HoTen;
                    Session.Add(CommonConstants.USER_SESSION, taikhoanSession);
                    return Redirect("/");
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
            return View(model);
        }
        public ActionResult Logout()
        {
            Session[CommonConstants.USER_SESSION] = null;
            return Redirect("/");
        }
        public ActionResult ThongTinChiTietThanhVien(int? mathanhvien)
        {
            //var thanhvien = new DangNhapThanhVienDao().ViewDetail(mathanhvien);
            //ViewBag.loaithanhvien = new TheLoaiDao().ViewDetail(thanhvien.MaLoaiThanhVien);
            //return View(thanhvien);
            var db = new DulichBuiDbContext();
           
                ThanhVien tv = (from thanhvien in db.ThanhVien where thanhvien.MaThanhVien == mathanhvien select thanhvien).SingleOrDefault();
                return View(tv);
        }
        [HttpGet]
        public ActionResult DangKiThanhVien()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKiThanhVien(DangKiThanhVienModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new DangNhapThanhVienDao();
                if (dao.CheckTaiKhoan(model.TaiKhoan))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.CheckEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email đã tồn tại");
                }
                else
                {
                    var taikhoan = new ThanhVien();
                    taikhoan.MatKhau = model.MatKhau;
                    taikhoan.HoTen = model.HoTen;
                    taikhoan.Email = model.Email;
                    taikhoan.SDT = model.SDT;
                    taikhoan.DiaChi = model.DiaChi;
                    taikhoan.NgayDangKi = DateTime.Now;
                    taikhoan.TrangThai = true;

                    var result = dao.DangKiThanhVien(taikhoan);
                    if (result > 0)
                    {
                        ViewBag.Success = "Đăng ký thành công";
                        //model = new DangKiThanhVienModel();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công.");
                    }

                }
            }
            return View(model);
        }
    }
}