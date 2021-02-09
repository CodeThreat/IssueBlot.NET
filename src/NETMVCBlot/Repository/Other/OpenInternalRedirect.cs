using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NETMVCBlot.Repository.Other
{
    public class OpenInternalRedirect : System.Web.UI.Page
    {
        public void Run()
        {
            String urlContext = Request["redir"];

            // CTSECISSUE: OpenInternalRedirect
            Response.Redirect(Request.Url.Authority + urlContext);
            
        }
    }
}