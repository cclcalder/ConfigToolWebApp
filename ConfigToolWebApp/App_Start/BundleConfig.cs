using System.Web;
using System.Web.Optimization;

namespace ConfigToolWebApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jQuery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jQuery/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //AngularJS 
            bundles.Add(new ScriptBundle("~/bundles/angularJS").Include(
                        "~/Scripts/AngularJS/angular.js",
                        "~/Scripts/AngularJS/angular-route.js",
                        "~/Scripts/AngularJS/angular-resource.js"));

            //AGGrid
            bundles.Add(new ScriptBundle("~/bundles/aggrid").Include(
                        "~/Scripts/ag-grid/dist/ag-grid.js",
                        "~/Scripts/ag-grid/dist/styles/ag-grid.css"));

            //Angular-material and dependancies (Animate, Aria)
            bundles.Add(new ScriptBundle("~/bundles/angularmaterial").Include(
                        "~/Scripts/angular-material/angular-material.js",
                        "~/Scripts/angular-animate/angular-animate.js",
                        "~/Scripts/angular-aria/angular-aria.js",
                        "~/Scripts/angular-material/angular-material.min.css"));

            //BootstrapJS
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js"));

            //Main CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/site.css"));
        }
    }
}
