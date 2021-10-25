using NETMVCBlot.Models;
using NETMVCBlot.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace NETMVCBlot.Controllers
{
    public class HomeController : Controller
    {
        // CTSECISSUE:DisabledRequestValidation
        [ValidateInput(false)]
        public ActionResult Index(string name="")
        {
            // CTSECISSUE:PossiblyInsecureUseofX-Forwarded-For
            string addr = Request.Headers["X-Forwarded-For"];
            if (addr == null)
            {
                addr = Request.UserHostAddress;
            }
            else
            {
                addr = addr.Split(',')[0];
            }

            return View();
        }

        public ActionResult About()
        { 
            // CTSECISSUE:Insecure Hidden Field
            HtmlInputHidden hidden = new HtmlInputHidden();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Bill(int billid)
        {
            BillRepository billRepository = new BillRepository();
            return View(billRepository.GetBill(billid));
        }
        public ActionResult BillEF(int billid)
        {
            BillRepository billRepository = new BillRepository();
            return View(billRepository.GetBillEF(billid));
        }

        [HttpPost]
        public ActionResult AddBill(Bill bill)
        {
            BillRepository ctx = new BillRepository();
            ctx.AddBillEF(bill);

            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {

            if (file.ContentLength > 0)
            {
                var fName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/uplds"), fName);
                //CTSECISSUE:PossibleInsecureFileUpload
                file.SaveAs(path);
            }

            return RedirectToAction("Index");
        }

        // CTSECISSUE:CrossSiteRequestForgery(CSRF)
        [HttpPost]
        public ActionResult RegisterPerson(Person person)
        {
            return View();
        }

        // CTSECISSUE:CrossSiteRequestForgery(CSRF)
        [HttpDelete]
        public ActionResult RemovePerson(int id)
        {
            return View();
        }

        // CTSECISSUE:CrossSiteRequestForgery(CSRF)
        [HttpPut]
        public ActionResult EditPerson(Person person)
        {
            return View();
        }

        public ActionResult Control()
        {
            // CTSECISSUE:InadequateAuthorizationMechanism
            bool test = User.IsInRole("administrator");
            if (test)
            {
            }            
            else
            {
            }

            return View();
        }

        public ActionResult ShowBill(int id)
        {
            BillRepository billRepository = new BillRepository();
            ViewBag.BillDescription = billRepository.GetBillDescription(id);
            return View();
        }

        public ActionResult SaveMe(Person person)
        {
            // CTSECISSUE:HTTPCookieInjection
            HttpCookie cookie = new HttpCookie("lastpersonname", person.Name);
            Response.Cookies.Add(cookie);

            // CTSECISSUE:HTTPCookieInjection
            HttpCookie cookie2 = new HttpCookie("lastpersonname");
            cookie2.Value = person.Name;
            Response.Cookies.Add(cookie2);

            //CTSECISSUE:Cookie not Sent Over SSL
            Response.AppendCookie(cookie);

            //CTSECISSUE:Overly Broad Path
            cookie.Path = "/";

            //CTSECISSUE:Overly Broad Domain
            cookie.Domain = ".example.com";

            return View();
        }
        public void LosFormatterDeserialization(string json)
        {
            try
            {
                // ruleid: insecure-losformatter-deserialization
                LosFormatter losFormatter = new LosFormatter();
                object obj = losFormatter.Deserialize(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}