﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AutomaticTellerMachine
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Using Route
            //routes.MapRoute(
            //   name: "Serial number",
            //   url: "serial/{letterCase}",
            //   defaults: new { controller = "Home", action = "Serial", letterCase = "upper" }
            //);

            //Using query String
            routes.MapRoute(
               name: "Serial number",
               url: "serial",
               defaults: new { controller = "Home", action = "Serial" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
