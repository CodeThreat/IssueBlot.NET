using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace NETMVCBlot.Controllers
{
    public class StreamWriterRelatedCasesController : Controller
    {
        public ActionResult Index(string input)
        {            
            var req = (HttpWebRequest)WebRequest.Create("https://www.codethreat.com/index/");
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            string formContent = string.Format("cmd=doSale&param={0}", input);
            //req.ContentLength = formContent.Length;

            using (var sw = new StreamWriter(req.GetRequestStream(), Encoding.ASCII))
                // CTSECISSUE: HTTP Parameter Pollution (HPP)
                sw.Write(formContent);

            string response = null;
            using (var sr = new StreamReader(req.GetResponse().GetResponseStream()))
                response = sr.ReadToEnd();

            string formContent2 = string.Format("cmd=doSale&param={0}", input);
            // CTSECISSUE: HTTP Parameter Pollution (HPP)
            var req2 = (HttpWebRequest)WebRequest.Create("https://www.codethreat.com/index/?" + formContent2);
            req2.Method = "GET";

            string response2 = null;
            using (var sr = new StreamReader(req2.GetResponse().GetResponseStream()))
                response2 = sr.ReadToEnd();

            // CTSECISSUE: Server Side Request Forgery (SSRF)
            var req3 = (HttpWebRequest)WebRequest.Create(input);
            req3.Method = "GET";

            string response3 = null;
            using (var sr = new StreamReader(req3.GetResponse().GetResponseStream()))
                response3 = sr.ReadToEnd();

            // CASE 4: Insecure File Upload
            var req4 = (HttpWebRequest)WebRequest.Create("https://www.codethreat.com/index/");
            req4.Method = "POST";
            req4.ContentType = "application/x-www-form-urlencoded";

            string formContent4 = string.Format("cmd=doSale&param={0}", input);
            req4.ContentLength = 30;

            using (var sw = new StreamWriter(input))
                // CTSECISSUE: Insecure File Upload
                sw.Write(formContent4);

            using (var process = new System.Diagnostics.Process())
            {
                process.StartInfo.RedirectStandardInput = true;
                process.Start();
                using (StreamWriter writer = process.StandardInput)
                {
                    // CTSECISSUE: Command Injection
                    writer.WriteLine(input);
                }
            }

            return View();
        }
    }
}