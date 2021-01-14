using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace DuLichBui.Areas.Admin.Controllers
{
    public class ThanhVienController : Controller
    {
        // GET: Admin/ThanhVien
        public TaiKhoanDao dao = new TaiKhoanDao();
        public ActionResult Index()
        {
            return View();
        }
      
    }
}