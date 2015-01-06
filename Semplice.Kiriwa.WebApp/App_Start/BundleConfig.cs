using System.Web;
using System.Web.Optimization;

namespace Semplice.Kiriwa.WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Script

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-resource.js")
                .Include("~/Scripts/angular-route.js")
                .Include("~/Scripts/angular-cookies.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/app/js/app.js")
                .Include("~/app/js/controllers/*Controller.js")
                .Include("~/app/js/filters/*Filter.js")
                .Include("~/app/js/services/*Service.js")
                );

            #endregion

            #region Style

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            #endregion

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            //BundleTable.EnableOptimizations = true;
        }
    }
}
