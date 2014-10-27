using System.Web;
using System.Web.Optimization;

namespace MM.WebApi
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/mastermind").Include(
                      "~/Scripts/CreateGame.js",
                      "~/Scripts/Board.js",
                      "~/Scripts/app.js",
                      "~/Scripts/codeGenerator.js",
                      "~/Scripts/game.js",
                      "~/Scripts/Validate.js",
                      "~/Scripts/templates.js",
                      "~/Scripts/Mastermind_Template_View.js",
                      "~/Scripts/GameSetupView.js",
                      "~/Scripts/BoardView.js",
                      "~/Scripts/GuessInputView.js",
                      "~/Scripts/MastermindView.js"));

            bundles.Add(new ScriptBundle("~/bundles/bower_components").Include(
                    "~/Scripts/bower_components/jquery/jquery.js",
                    "~/Scripts/bower_components/jquery-ui/jquery-ui.min.js",
                    "~/Scripts/bower_components/jquery-validation/dist/jquery.validate.min.js",
                    "~/Scripts/bower_components/jquery-validation/dist/additional-methods.min.js",
                    "~/Scripts/bower_components/underscore/underscore.js",
                    "~/Scripts/bower_components/backbone/backbone.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/app/styles/styles.css"));
        }
    }
}
