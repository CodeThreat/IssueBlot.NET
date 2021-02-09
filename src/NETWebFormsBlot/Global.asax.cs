using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace NETWebFormsBlot
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_PreSendRequestHeaders()
        {
            // CTSECISSUE:InsecureX-XSS-ProtectionConfiguration
            HttpContext.Current.Response.Headers.Add("X-XSS-Protection", "0");

            Response.Headers.Remove("X-AspNetMvc-Version");

            HttpContext.Current.Response.Headers.Add("X-Frame-Options", "DENY");


            HttpContext.Current.Response.Headers.Add("X-Content-Type-Options", "nosniff");
            HttpContext.Current.Response.Headers.Remove("Server");
            Response.Headers.Remove("X-AspNet-Version");
        }
    }
}