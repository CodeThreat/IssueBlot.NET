using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETWebFormsBlot
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // CTSECISSUE:MissingHttpOnlyCookieAttribute
            HttpCookie cookie1 = new HttpCookie("name", "");

            // CTNONSECISSUE:MissingHttpOnlyCookieAttribute
            HttpCookie cookie2 = new HttpCookie("name", "");
            //SetSecureDetails(cookie2);
            cookie2.HttpOnly = true;
            cookie2.Secure = true;

            // CTSECISSUE:MissingSecureCookieAttribute
            HttpCookie cookie3 = new HttpCookie("name", "");

            // CTNONSECISSUE:MissingSecureCookieAttribute
            HttpCookie cookie4 = new HttpCookie("name", "");
            cookie4.Secure = true;
            cookie4.HttpOnly = true;
        }

        private void SetSecureDetails(HttpCookie cookie)
        {
            cookie.Secure = true;
            cookie.HttpOnly = true;
        }
    }
}