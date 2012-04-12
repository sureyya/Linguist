using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Linguist.Utility
{
    public static class LinguistBundle
    {
        public static void EnableBootstrapBundle(this BundleCollection bundles)
        {
            //var bootstrapCss = new Bundle("~/bootstrap/css", new CssMinify());
            //bootstrapCss.AddFile("~/css/bootstrap.css");
            //bootstrapCss.AddFile("~/css/bootstrap-responsive.css");
            //bootstrapCss.AddFile("~/css/application.css");
            //bootstrapCss.AddFile("~/css/prettify.css");

            //bundles.Add(bootstrapCss);

            //var bootstrapJs =BundleTable.Bundles.GetBundleFor( new Bundle("~/bootstrap/js", new JsMinify());
            var bootstrapJs = BundleTable.Bundles.GetBundleFor("~/Scripts/js");
            bootstrapJs.AddFile("~/Scripts/3thParty/knockout.js");
            bootstrapJs.AddFile("~/Scripts/3thParty/knockout.mapping-latest.js");
            //bootstrapJs.AddFile("~/Scripts/Tabzilla.js");     
            bundles.Add(bootstrapJs);
        }
    }
}