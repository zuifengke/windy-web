using System.Web;
using System.Web.Optimization;

namespace Bootstrap_FileUpload
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                        "~/Content/bootstrap/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Content/bootstrap-fileinput/js").Include(
                        "~/Content/bootstrap-fileinput/js/fileinput.js",
                        "~/Content/bootstrap-fileinput/js/fileinput_locale_zh.js"));



            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/css").Include(
                        "~/Content/bootstrap/css/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/Content/bootstrap-fileinput/css").Include(
                        "~/Content/bootstrap-fileinput/css/fileinput.css"));

            //页面js
            bundles.Add(new ScriptBundle("~/Home/Index").Include(
                        "~/Scripts/Home/index.js"));

        }
    }
}
