using System.Web;
using System.Web.Optimization;

namespace AdminTET
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Static/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/staticJS").Include(
                      "~/Content/Static/axios/axios.js",
                      "~/Content/Static/vue/vue.js",
                      "~/Content/Static/elementUI/index.js"));
            
            bundles.Add(new StyleBundle("~/Content/elementUI/css").Include(
                      "~/Content/Static/elementUI/index.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/site.css"));
        }
    }
}