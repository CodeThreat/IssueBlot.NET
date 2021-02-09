using NETMVCBlot.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NETMVCBlot.Controllers
{
    public class FileController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Download(string fileName)
        {
            if (!IBValidator.IsValidFileName(fileName))
                return new HttpNotFoundResult();

            // CTSECISSUE:DirectoryTraversal
            return new FilePathResult(@"D:\wwwroot\reports\" + fileName, "application/pdf");
        }
    }
}