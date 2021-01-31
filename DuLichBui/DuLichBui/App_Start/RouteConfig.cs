using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DuLichBui
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
            name: "About",
            url: "gioi-thieu",
            defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "DuLichBui.Controllers" }
        );
            routes.MapRoute(
            name: "Contact",
            url: "lien-he",
            defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "DuLichBui.Controllers" }
        );
            
            routes.MapRoute(
        name: "Food",
        url: "am-thuc",
        defaults: new { controller = "Food", action = "Index", id = UrlParameter.Optional },
        namespaces: new[] { "DuLichBui.Controllers" }
    );
            routes.MapRoute(
         name: "Travel",
         url: "du-lich",
         defaults: new { controller = "Travel", action = "Index", id = UrlParameter.Optional },
         namespaces: new[] { "DuLichBui.Controllers" }
     );
                  routes.MapRoute(
         name: "Home",
         url: "trang-chu",
         defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
         namespaces: new[] { "DuLichBui.Controllers" }
     );
            routes.MapRoute(
        name: "DangBaiViet",
        url: "dang-bai",
        defaults: new { controller = "DangBaiViet", action = "Index", id = UrlParameter.Optional },
        namespaces: new[] { "DuLichBui.Controllers" }
    );
            routes.MapRoute(
     name: "ThemBaiViet",
     url: "them-bai-viet",
     defaults: new { controller = "DangBaiViet", action = "ThemBaiViet", id = UrlParameter.Optional },
     namespaces: new[] { "DuLichBui.Controllers" }
 );
            routes.MapRoute(
     name: "ThongTinThanhVien",
     url: "thong-tin-thanh-vien",
     defaults: new { controller = "DangNhapThanhVien", action = "ThongTinChiTietThanhVien", id = UrlParameter.Optional },
     namespaces: new[] { "DuLichBui.Controllers" }
 );
            routes.MapRoute(
  name: "ChiTietBaiViet",
  url: "chi-tiet-bai-viet",
  defaults: new { controller = "ChiTietBaiViet", action = "Index", id = UrlParameter.Optional },
  namespaces: new[] { "DuLichBui.Controllers" }
);
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
