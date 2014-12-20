using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Semplice.Kiriwa.WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Handle AngularJS and ASP.Net MVC routes, to co-exist together.
            // http://www.jlum.ws/post/2014/10/10/handling-routes-between-an-angularjs-application-and-aspnet-mvc-application
            routes.MapRoute(
                name: "AngularCatchAllRoute",
                url: "App/{*.}",
                defaults: new { controller = "App", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "App", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
