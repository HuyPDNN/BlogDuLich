using DuLichBui.Common;
using DuLichBui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace DuLichBui.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.danhsachbaiviet = new BaiVietDao().DanhSachBaiViet();
            ViewBag.listinfothanhvien = new DangNhapThanhVienDao().ListInfoThanhVien();
            ViewBag.dsTheLoai = new TheLoaiDao().DSTheLoai();
            return View();
        }
        public ActionResult ListInfoThanhVien()
        {
            var list = new DangNhapThanhVienDao().ListInfoThanhVien();
            return View(list);
        }
        public ActionResult DSTheLoai()
        {
            var list = new TheLoaiDao().DSTheLoai();
            return View(list);
        }
        public ActionResult DanhSachBaiViet()
        {
            var list = new BaiVietDao().DanhSachBaiViet();
            return View(list);
        }

        

        //public ActionResult CapNhatThongTiinThanhVien(string mathanhvien)
        //{
        //    var thanhvien = new DangNhapThanhVienDao().ViewDetail(mathanhvien);
        //    return View(thanhvien);
        //}
    }
}