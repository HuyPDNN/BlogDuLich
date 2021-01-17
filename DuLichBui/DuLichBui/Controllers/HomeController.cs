using DuLichBui.Common;
using DuLichBui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
namespace DuLichBui.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            DulichBuiDbContext db = new DulichBuiDbContext();
            ViewBag.danhsachbaiviet = new BaiVietDao().DanhSachBaiViet(page, pagesize);
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
        public ActionResult DanhSachBaiViet(int page = 1, int pagesize = 10)
        {
            var list = new BaiVietDao().DanhSachBaiViet(page, pagesize);
            return View(list);
        }


    }
}