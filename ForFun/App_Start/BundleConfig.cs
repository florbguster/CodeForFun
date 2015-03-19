using System.Web.Optimization;

namespace CodeForFun
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles( BundleCollection bundles )
        {
            // main
            bundles.Add( new StyleBundle( "~/main/style" )
                   .Include( "~/Content/Site.css" ) );

            // box game
            bundles.Add( new StyleBundle( "~/boxGame/style" )
                   .Include( "~/Content/Game.css" ) );

            bundles.Add( new ScriptBundle( "~/boxGame/js" )
                   .Include( "~/Scripts/jquery-{version}.js",
                             "~/Scripts/modernizr-{version}.js",
                             "~/Scripts/Game.js" ) );


            // car registry
            bundles.Add( new StyleBundle( "~/carRegistry/style" )
                   .Include( "~/Content/CarRegistry.css" ) );


            bundles.Add( new ScriptBundle( "~/carRegistry/js" )
                   .Include( "~/Scripts/jquery-{version}.js",
                             "~/Scripts/modernizr-{version}.js",
                             "~/Scripts/angular.js",
                             "~/Scripts/CarRegistry.js" ) );

        }
    }
}
