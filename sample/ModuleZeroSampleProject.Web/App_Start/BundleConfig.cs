﻿using System.Web.Optimization;

namespace ModuleZeroSampleProject.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            #region Bundles for Angular application (private pages, entered after login)
            
            //VENDOR RESOURCES

            //~/Bundles/App/vendor/css
            bundles.Add(
                new StyleBundle("~/Bundles/App/vendor/css")
                    .Include(
                        "~/Content/themes/base/all.css",

                        "~/Content/bootstrap.min.css",

                        "~/bower_components/bootstrap-material-design/dist/css/ripples.min.css",
                        "~/bower_components/bootstrap-material-design/dist/css/material-wfont.min.css",
                        "~/bower_components/angular-material/angular-material.min.css",
                        "~/bower_components/angular-material/themes/blue-theme.css",

                        "~/Content/toastr.min.css",
                        "~/Content/flags/famfamfam-flags.css",
                        "~/Content/font-awesome.min.css"
                    )
                );

            //~/Bundles/App/vendor/js
            bundles.Add(
                new ScriptBundle("~/Bundles/App/vendor/js")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/json2.min.js",

                        "~/Scripts/modernizr-2.8.3.js",

                        "~/Scripts/jquery-2.1.3.min.js",
                        "~/Scripts/jquery-ui-1.11.4.min.js",

                        "~/Scripts/bootstrap.min.js",
                        "~/bower_components/bootstrap-material-design/dist/css/ripples.min.js",
                        "~/bower_components/bootstrap-material-design/dist/css/material.min.js",

                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.min.js",
                        "~/bower_components/spin.js/spin.js",
                        "~/bower_components/spin.js/jquery.spin.js",

                        "~/bower_components/angular/angular.min.js",
                        "~/bower_components/angular-animate/angular-animate.min.js",
                        "~/bower_components/angular-sanitize/angular-sanitize.min.js",
                        "~/bower_components/angular-aria/angular-aria.min.js",
                        "~/bower_components/angular-ui-router/release/angular-ui-router.min.js",

                        "~/bower_components/hammerjs/hammer.min.js",

                        "~/bower_components/angular-material/angular-material.min.js",

                        "~/Scripts/angular-ui/ui-bootstrap.min.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                        "~/Scripts/angular-ui/ui-utils.min.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js",
                        "~/Abp/Framework/scripts/libs/angularjs/abp.ng.js"
                    )
                );

            //APPLICATION RESOURCES

            //~/Bundles/App/Main/css
            bundles.Add(
                new StyleBundle("~/Bundles/App/Main/css")
                    .IncludeDirectory("~/App/Main", "*.css", true)
                );

            //~/Bundles/App/Main/js
            bundles.Add(
                new ScriptBundle("~/Bundles/App/Main/js")
                    .IncludeDirectory("~/App/Main", "*.js", true)
                );

            #endregion

            #region Bundles for MVC application (public pages, can be seen without login)

            //VENDOR RESOURCES

            //~/Bundles/vendor/css
            bundles.Add(
                new StyleBundle("~/Bundles/vendor/css")
                    .Include(
                        "~/Content/themes/base/all.css",

                        "~/Content/bootstrap.min.css",
                        "~/bower_components/bootstrap-material-design/dist/css/ripples.min.css",
                        "~/bower_components/bootstrap-material-design/dist/css/material-wfont.min.css",

                        "~/Content/toastr.min.css",
                        "~/Content/flags/famfamfam-flags.css",
                        "~/Content/font-awesome.min.css"
                    )
                );

            //~/Bundles/vendor/js/top (These scripts should be included in the head of the page)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/top")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/modernizr-2.8.3.js"
                    )
                );

            //~/Bundles/vendor/bottom (Included in the bottom for fast page load)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/bottom")
                    .Include(
                        "~/Scripts/json2.min.js",

                        "~/Scripts/jquery-2.1.3.min.js",
                        "~/Scripts/jquery-ui-1.11.4.min.js",

                        "~/Scripts/bootstrap.min.js",
                        "~/bower_components/bootstrap-material-design/dist/css/ripples.min.js",
                        "~/bower_components/bootstrap-material-design/dist/css/material.min.js",

                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.min.js",
                        "~/bower_components/spin.js/spin.js",
                        "~/bower_components/spin.js/jquery.spin.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js"
                    )
                );

            //APPLICATION RESOURCES

            //~/Bundles/css
            bundles.Add(
                new StyleBundle("~/Bundles/css")
                    .Include("~/css/main.css")
                );

            //~/Bundles/js
            bundles.Add(
                new ScriptBundle("~/Bundles/js")
                    .Include("~/js/main.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/adminLTE/js").
                Include(
                "~/Scripts/bootstrap.js", 
                "~/Scripts/jquery-{version}.js",
                "~/App/Main/AdminLTE/plugins/iCheck/icheck.min.js"));

            bundles.Add(new ScriptBundle("~/adminLTE/js").
                Include("~/Scripts/bootstrap.js",
                "~/Scripts/jquery-{version}.js",
                "~/App/Main/AdminLTE/plugins/iCheck/icheck.min.js"));

            bundles.Add(new ScriptBundle("~/login/js").
                Include("~/Abp/Framework/scripts/libs/abp.jquery.js", "~/abp/framework/scripts/abp.js", "~/js/Account/login.js"));

            bundles.Add(
                new StyleBundle("~/adminLTE/css")
                    .Include("~/Content/bootstrap.min.css", 
                    "~/App/Main/AdminLTE/dist/css/AdminLTE.min.css", 
                    "~/App/Main/AdminLTE/plugins/iCheck/square/blue.css")
                );

            bundles.Add(
                new StyleBundle("~/adminLTE/main/css")
                    .Include("~/Content/bootstrap.min.css",
                    "~/App/Main/AdminLTE/dist/css/AdminLTE.min.css",
                    "~/App/Main/AdminLTE/plugins/iCheck/square/blue.css",
                    "~/App/Main/AdminLTE/dist/css/skins/_all-skins.min.css",
                    "~/App/Main/AdminLTE/iconfont/css/ionicons.min.css",
                    "~/App/Main/AdminLTE/plugins/morris/morris.css",
                    "~/App/Main/AdminLTE/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                    "~/App/Main/AdminLTE/plugins/datepicker/datepicker3.css",
                    "~/App/Main/AdminLTE/plugins/daterangepicker/daterangepicker-bs3.css",
                    "~/App/Main/AdminLTE/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"
                    )
                );

            bundles.Add(
                new ScriptBundle("~/adminLTE/main/js")
                    .Include(
                    "~/App/Main/AdminLTE/plugins/jQuery/jQuery-2.1.4.min.js",
                    "~/App/Main/AdminLTE/plugins/jQuery/jquery-ui.min.js",
                    "~/bower_components/angular/angular.min.js",
                    "~/Scripts/bootstrap.min.js",
                    "~/App/Main/AdminLTE/plugins/morris/morris.min.js",
                    "~/App/Main/AdminLTE/plugins/sparkline/jquery.sparkline.min.js",
                    "~/App/Main/AdminLTE/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                    "~/App/Main/AdminLTE/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                    "~/App/Main/AdminLTE/plugins/knob/jquery.knob.js",
                    "~/App/Main/AdminLTE/plugins/daterangepicker/daterangepicker.js",
                    "~/App/Main/AdminLTE/plugins/datepicker/bootstrap-datepicker.js",
                    "~/App/Main/AdminLTE/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                    "~/App/Main/AdminLTE/plugins/slimScroll/jquery.slimscroll.min.js",
                    "~/App/Main/AdminLTE/plugins/fastclick/fastclick.min.js",
                    "~/App/Main/AdminLTE/dist/js/app.min.js",
                    "~/App/Main/AdminLTE/dist/js/pages/dashboard.js",
                     "~/App/Main/AdminLTE/dist/js/demo.js",
                     "~/Abp/Framework/scripts/libs/abp.jquery.js", 
                     "~/abp/framework/scripts/abp.js", "~/js/Account/login.js"
                    )
                );

            #endregion
        }
    }
}