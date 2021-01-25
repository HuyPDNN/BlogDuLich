using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace DuLichBui.Controllers
{
    public class ChiTietThanhVienController : Controller
    {
        // GET: TacGia
        public ActionResult Index(long id)
        {
           
                var tacgia = new ThanhVienDao().chitiet(id);
                return View(tacgia);
        }
        [HttpGet]
        public ActionResult CapNhatThongTinThanhVien(int id)
        {
            var thanhvien = new ThanhVienDao().chitiet(id);
            return View(thanhvien);
        }
        [HttpPost]
        public ActionResult CapNhatThongTinThanhVien(ThanhVien thanhvien)
        {
            if (ModelState.IsValid)
            {
                var dao = new ThanhVienDao();
                var response = dao.CapNhatThongTinThanhVIen(thanhvien);
                if (response)
                {
                   
                    return RedirectToAction( "Index"+ "/" + thanhvien.MaThanhVien, "ChiTietThanhVien");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật không thành công.");
                }
            }
            return View("Index");
        }

    }
}