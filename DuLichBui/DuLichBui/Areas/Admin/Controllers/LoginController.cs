using DuLichBui.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuLichBui.Common;
using Model.Dao;

namespace DuLichBui.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new TaiKhoanDao();
                var result = dao.Login(model.Taikhoan, model.Matkhau);
                if(result == 1)
                {
                    var taikhoan = dao.GetById(model.Taikhoan);
                    var taikhoanSession = new TaiKhoanLogin();
                    taikhoanSession.TaiKhoan = taikhoan.TaiKhoan1;
                    taikhoanSession.TaiKhoanID = taikhoan.MaTaiKhoan;
                    Session.Add(CommonConstants.USER_SESSION, taikhoanSession);
                    return RedirectToAction("Index", "Home");
                }
                else if(result==0){
                    ModelState.AddModelError("","Tài khoản không tồn tại");
                }
                else if(result == -1)
                {
                    ModelState.AddModelError("", "Tài Khoản đang bị khóa");
                }
                else if(result==-2)
                {
                    ModelState.AddModelError("","Mật khẩu không đúng");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng");
                }
            }
            return View("Index");
        }
    }
}