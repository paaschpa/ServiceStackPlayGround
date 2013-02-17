using System.Web.Optimization;

namespace SS_Demo
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/extjs").Include(
                "~/Scripts/extjs/ext-all-debug.js",
                "~/Scripts/extjs/ext-neptune-debug.js",
                "~/Scripts/app/Ajax/DataRetriever.js"));

            bundles.Add(new ScriptBundle("~/bundles/servicecounter").Include(
                "~/Scripts/app/Types/MakeModel.js",
                "~/Scripts/app/Types/Order.js",
                "~/Scripts/app/Types/ServiceAdvisor.js",
                "~/Scripts/app/Views/RepairOrderForm.js",
                "~/Scripts/app/Views/OrdersGrid.js"));

            bundles.Add(new StyleBundle("~/Scripts/neptune/css").Include(
                "~/Scripts/resources/css/ext-neptune.css",
                "~/Scripts/resources/css/sink.css"));

            //bundles.Add(new StyleBundle("~/Content/site/css").Include("~/Content/Site.css"));
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-1.*"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui*"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            //            "~/Content/themes/base/jquery.ui.core.css",
            //            "~/Content/themes/base/jquery.ui.resizable.css",
            //            "~/Content/themes/base/jquery.ui.selectable.css",
            //            "~/Content/themes/base/jquery.ui.accordion.css",
            //            "~/Content/themes/base/jquery.ui.autocomplete.css",
            //            "~/Content/themes/base/jquery.ui.button.css",
            //            "~/Content/themes/base/jquery.ui.dialog.css",
            //            "~/Content/themes/base/jquery.ui.slider.css",
            //            "~/Content/themes/base/jquery.ui.tabs.css",
            //            "~/Content/themes/base/jquery.ui.datepicker.css",
            //            "~/Content/themes/base/jquery.ui.progressbar.css",
            //            "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}