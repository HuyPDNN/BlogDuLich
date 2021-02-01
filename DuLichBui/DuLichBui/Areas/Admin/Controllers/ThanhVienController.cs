using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.AdminModel;

namespace DuLichBui.Areas.Admin.Controllers
{
    public class ThanhVienController : Controller
    {
        // GET: Admin/ThanhVien
        public ThanhVienDao dao = new ThanhVienDao();
        public ActionResult Index(int page  = 1, int pagesize = 10)
        {
            var model = dao.DanhSachThanhVien(page, pagesize);
            return View(model);
        }
      
    }
}