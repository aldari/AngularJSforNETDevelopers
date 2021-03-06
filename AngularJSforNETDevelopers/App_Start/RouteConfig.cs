﻿using System.Web.Mvc;
using System.Web.Routing;

namespace AngularJSforNETDevelopers
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Registration Courses SPA",
                url: "Registration/Courses",
                defaults: new { controller = "Registration", action = "Index"});
            routes.MapRoute(
                name: "Registration Instructors SPA",
                url: "Registration/Instructors",
                defaults: new { controller = "Registration", action = "Index" });
            routes.MapRoute(
                name: "Registration Create Account SPA",
                url: "Registration/CreateAccount",
                defaults: new { controller = "Registration", action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Registration", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
