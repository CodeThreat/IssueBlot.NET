using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NETMVCBlot.Controllers.WebService
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string ReadFile(string fileName)
        {
            // CTSECISSUE:DirectoryTraversal
            return File.ReadAllText(@"D:\wwwroot\reports\" + fileName);
        }

        public string Helper(string fileName)
        {
            // CTSECNONISSUE:DirectoryTraversal
            return File.ReadAllText(@"D:\wwwroot\reports\" + fileName);
        }
    }
}
