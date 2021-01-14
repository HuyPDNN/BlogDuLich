using System.Web.Mvc;

namespace DuLichBui.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
            name: "HomeAdmin",
            url: "trang-chu-admin",
            defaults: new { controller = "HomeAdmin", action = "Index", id = UrlParameter.Optional }
             );
            context.MapRoute(
            name: "NhanVien",
            url: "nhan-vien",
            defaults: new { controller = "NhanVien", action = "DanhSachTaiKhoan", id = UrlParameter.Optional }
             );
            context.MapRoute(
           name: "ThanhVien",
           url: "thanh-vien",
           defaults: new { controller = "ThanhVien", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
           name: "BaiViet",
           url: "bai-viet",
           defaults: new { controller = "BaiViet", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
            name: "Login",
            url: "dang-nhap",
            defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
 );
        }
    }
}