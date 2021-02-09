using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETWebFormsBlot
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // Sources: Nearly all properties under System.Environment
            // Sources: Nearly all properties under System.Web.HttpRuntime

            // Sink: HttpCookie, Response, etc.

            // CTSECISSUE:SensitiveInformationExposure
            HttpCookie cookie0 = new HttpCookie("pwd", Environment.CurrentDirectory);

            // CTSECISSUE:SensitiveInformationExposure
            Response.Write("Logical Drives:" + string.Join("-", Environment.GetLogicalDrives()));

            // CTSECISSUE:SensitiveInformationExposure
            Response.Write("PWD: " + Environment.CurrentDirectory);

            // CTSECISSUE:SensitiveInformationExposure
            Response.Write("Machine Name: " + Environment.MachineName);

            // CTSECISSUE:SensitiveInformationExposure
            Response.Write("User Name: " + Environment.UserName);

            // CTSECISSUE:SensitiveInformationExposure
            Response.Write("System Directory: " + Environment.SystemDirectory);

            // CTSECISSUE:SensitiveInformationExposure
            Response.Write("App Domain App Path: " + HttpRuntime.AppDomainAppPath);
            
        }
    }
}