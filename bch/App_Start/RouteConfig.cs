using bch.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace bch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Create Folders for application to work.
            Directory.CreateDirectory(Processing.DataPath+ $"\\cars");
            Directory.CreateDirectory(Processing.DataPath + $"\\rentals");
            Directory.CreateDirectory(Processing.DataPath + $"\\clients");
        }
    }
}
