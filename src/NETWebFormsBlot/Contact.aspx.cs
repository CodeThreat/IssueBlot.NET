using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETWebFormsBlot
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String url = Request["redir"];
            // CTSECISSUE:OpenRedirect
            Response.Redirect(url);

            // CTSECISSUE:OpenRedirectInternal
            Response.Redirect(Request.Url.Authority + url);

            // sink: probably other *Decode methods provided by .NET Framework

            HttpCookie aCookie = Request.Cookies["corss"];
            // CTSECISSUE:PotentialUnsafeDecoding
            string corss = Server.UrlDecode(aCookie.Value);
            
            // CTSECISSUE:PotentialUnsafeDecoding
            string corss2 = HttpUtility.UrlDecode(aCookie.Value);

            // CTSECISSUE:PotentialUnsafeDecoding
            string corss3 = WebUtility.UrlDecode(aCookie.Value);

            string description = Request["desc"];
            
            // CTSECISSUE:PotentialUnsafeDecoding
            string decodedDescription = Server.HtmlDecode(description);

            // CTSECISSUE:PotentialUnsafeDecoding
            string decodedDescription2 = HttpUtility.HtmlDecode(description);

            // CTSECISSUE:PotentialUnsafeDecoding
            HttpUtility.HtmlDecode(description, null);

            // CTSECISSUE:PotentialUnsafeDecoding
            string decodedDescription3 = WebUtility.HtmlDecode(description);

            // CTSECISSUE:PotentialUnsafeDecoding
            WebUtility.HtmlDecode(description, null);
        }
    }
}