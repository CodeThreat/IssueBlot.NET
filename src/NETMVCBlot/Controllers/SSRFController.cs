using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace NETMVCBlot.Controllers
{
    public class SSRFController : Controller
    {
        // GET: SSRF
        public ActionResult Index(string input)
        {
            string s = String.Empty;
            using (WebClient wc = new WebClient())
            {
                // CTSECISSUE: Server Side Request Forgery (SSRF)
                s = wc.DownloadString(input);
                ViewBag.StringDownloaded = s;
            }

            WebClient wc2 = new WebClient();
            // CTSECISSUE: Server Side Request Forgery (SSRF)
            // CTSECISSUE: HTTP Parameter Pollution (HPP)
            wc2.BaseAddress = input;

            WebClient wc3 = new WebClient();
            // CTSECISSUE: HTTP Parameter Pollution (HPP)
            wc3.BaseAddress = "https://www.target.com/i/" + input;

            HttpClient hc = new HttpClient();
            // CTSECISSUE: Server Side Request Forgery (SSRF)
            // CTSECISSUE: HTTP Parameter Pollution (HPP)
            hc.BaseAddress = new Uri(input);

            HttpClient hc2 = new HttpClient();
            // CTSECISSUE: HTTP Parameter Pollution (HPP)
            hc2.BaseAddress = new Uri("https://www.target.com/i/" + input);


            return View();
        }
    }
}