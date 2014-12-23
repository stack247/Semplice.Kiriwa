using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Semplice.Kiriwa.WebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Bug: fix for JSON serializing reference loop issue.
            // http://stackoverflow.com/questions/7397207/json-net-error-self-referencing-loop-detected-for-type
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling
                = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}
