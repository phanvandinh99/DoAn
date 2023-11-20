﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuanLyNhaHang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Chạy trang nhân viên Admin đầu tiên
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { Controller = "DangNhap", action = "DangNhap", id = UrlParameter.Optional },
                namespaces: new string[] { "QuanLyNhaHang.Areas.NhanVien.Controllers" }
            ).DataTokens.Add("area", "NhanVien");

        }
    }
}

