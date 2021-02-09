using NETMVCBlot.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NETMVCBlot.Controllers
{
    public class CallbackController : BaseController
    {
        protected override void Utility()
        {

        }

        [HttpPost]
        public ActionResult Download(string fileName)
        {
            if (!IBValidator.IsValidFileName(fileName))
                return new HttpNotFoundResult();

            // CTSECISSUE:DirectoryTraversal
            return new FilePathResult(@"D:\wwwroot\reports\" + fileName, "application/pdf");
        }

        public String DownloadAsString(string fileName)
        {
            // CTSECISSUE:DirectoryTraversal
            return System.IO.File.ReadAllText(@"D:\wwwroot\reports\" + fileName);
        }

        public JsonResult ExecuteProcess(string argument)
        {
            // CTSECISSUE: OSCommandInjection
            Process.Start("cmd.exe", "/C ping.exe " + argument);
            return null;
        }
    }
}