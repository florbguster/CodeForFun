using System.Web.Optimization;

namespace ForFun
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles( BundleCollection bundles )
        {
            bundles.Add( new ScriptBundle( "~/bundles/js" )
                .Include( "~/Scripts/jquery-{version}.js",
                          "~/Scripts/modernizr-*",
                          "~/Scripts/CarRegistry.js",
                          "~/Scripts/Game.js" ) );

            bundles.Add( new StyleBundle( "~/Content/styles" )
                .Include( "~/Content/Site.css",
                          "~/Content/Game.css" ) );
        }
    }
}
