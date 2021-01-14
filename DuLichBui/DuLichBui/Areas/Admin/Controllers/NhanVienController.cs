using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace DuLichBui.Areas.Admin.Controllers
{
    public class NhanVienController : Controller
    {
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
    }
}