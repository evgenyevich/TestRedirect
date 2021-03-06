﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestRedirect
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
            "",
            new
            {
                controller = "Home",
                action = "Index",
                canredirect = (bool)false,
                qty = 0
            }
            );
            routes.MapRoute("MyRoute",
            "Qty{qty}",
            new { controller = "Home", action = "Index", canredirect = false},new { qty = @"\d+" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = typeof(string) }
            );
        }
    }
}
