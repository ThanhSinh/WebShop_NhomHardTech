using System.Web;
using System.Web.Optimization;

namespace WebShop_NhomHardTech
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/js_them1").Include(
                 "~/Content/js/bootstrap.js",
                   "~/Content/js/jquery.js",
                     "~/Content/js/price-range.js",
                       "~/Content/js/jquery.scrollUp.min.js",
                         "~/Content/js/jquery.prettyPhoto.js",
                           "~/Content/js/main.js"
                   ));
           /* < script src = "js/jquery.js" ></ script >
 
     < script src = "js/price-range.js" ></ script >
  
      < script src = "js/jquery.scrollUp.min.js" ></ script >
   
       < script src = "js/bootstrap.min.js" ></ script >
    
        < script src = "js/jquery.prettyPhoto.js" ></ script >
     
         < script src = "js/main.js" ></ script >*/
                  bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css_them1").Include(
                "~/Content/bootstrap.css",
                      "~/Content/css/font-awesome.min.css",
                       "~/Content/css/prettyPhoto.css",
                        "~/Content/css/price-range.css",
                         "~/Content/css/animate.css",
                          "~/Content/css/main.css",
                          "~/Content/css/responsive.css",

                      "~/Content/site.css"));


            /* < link href = "css/font-awesome.min.css" rel = "stylesheet" >
   
       < link href = "css/prettyPhoto.css" rel = "stylesheet" >
      
          < link href = "css/price-range.css" rel = "stylesheet" >
         
             < link href = "css/animate.css" rel = "stylesheet" >
            
                < link href = "css/main.css" rel = "stylesheet" >
               
                   < link href = "css/responsive.css" rel = "stylesheet" >*/
        }
    }
}
