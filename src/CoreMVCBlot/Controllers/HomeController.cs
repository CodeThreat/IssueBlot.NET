using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVCBlot.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CoreMVCBlot.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;

        public IActionResult Index(string name="", string address="")
        {
            ViewBag.Name = name;
            ViewData["Address"] = address;
            ViewData["Host"] = Request.Host; // this is a source
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // CTSECISSUE:CrossSiteRequestForgery(CSRF)
        [HttpPost]
        public IActionResult Index(IFormFile image)
        {
            // Check if valid image type (can be extended with more rigorous checks)
            if (image == null)
            {
                return View();
            }

            if (image.Length < 1)
            {
                return View();
            }

            string[] allowedImageTypes = new string[] { "image/jpeg", "image/png" };

            //CTSECISSUE:PotentialUnsafeContentTypeCheck
            if (!allowedImageTypes.Contains(image.ContentType.ToLower()))
            {
                return View();
            }

            string imagesPath = Path.Combine(hostingEnvironment.WebRootPath, "images");
            string webPFileName = Path.GetFileNameWithoutExtension(image.FileName) + ".webp";
            string normalImagePath = Path.Combine(imagesPath, image.FileName);
            string webPImagePath = Path.Combine(imagesPath, webPFileName);

            //CTSECISSUE:PossibleInsecureFileUpload
            using (FileStream normalFileStream = new FileStream(normalImagePath, FileMode.Create))
            {
                image.CopyTo(normalFileStream);
            }

            return View();
        }

        public IActionResult Redirect(string gotourl = null, string redirect = null, string action = null, string controller = null)
        {
            if (!String.IsNullOrEmpty(gotourl))
            {
                // CTSECNONISSUE:OpenRedirect
                return Redirect(Url.Content("~/") + "#gotourl=" + Uri.EscapeDataString(gotourl));
            }

            if (!String.IsNullOrEmpty(action))
            {
                // CTSECISSUE:OpenRedirect
                return new RedirectToActionResult(action, null, null);
            }

            if (!String.IsNullOrEmpty(controller))
            {
                // CTSECISSUE:OpenRedirect
                return new RedirectToActionResult("index", controller, null);
            }

            // CTSECISSUE:OpenRedirect
            return Redirect(Url.Content("~/") + "#gotourl=" + redirect);
        }

    }
}
