using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NETMVCBlot.Controllers
{
    public class CodeInjectionController : Controller
    {
        public ActionResult Index()
        {
            string template = "Hello @Model.Name, welcome to RazorEngine!";
            // CTSECISSUE:MVCViewCodeInjection
            Engine.Razor.RunCompile(template, "key", null, new { Name = "World" });

            return View();
        }

    }
}