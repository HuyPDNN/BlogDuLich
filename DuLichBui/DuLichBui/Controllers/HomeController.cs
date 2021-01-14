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
        public ActionResult ThongTinChiTietThanhVien(string mathanhvien = "")
        {
       
            var db = new DulichBuiDbContext();
            if (mathanhvien != null)
            {
                ThanhVien tv = (from thanhvien in db.ThanhVien where thanhvien.MaThanhVien == mathanhvien select thanhvien).SingleOrDefault();
                return View(tv);
            }
            else
                return HttpNotFound("không");

        }


        //public ActionResult CapNhatThongTiinThanhVien(string mathanhvien)
        //{
        //    var thanhvien = new DangNhapThanhVienDao().ViewDetail(mathanhvien);
        //    return View(thanhvien);
        //}
    }
}