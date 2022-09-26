using NETMVCBlot.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NETMVCBlot.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ApimController : ApiController
    {
        
        [HttpPost]
        public HttpResponseMessage Add(Person person)
        {
            var resp = new HttpResponseMessage();

            // CTSECISSUE:HTTPCookieInjection
            var cookie = new CookieHeaderValue("lastpersonname", person.Name);
            resp.Headers.AddCookies(new CookieHeaderValue[] { cookie });
			
			   // CTSECISSUE:HTTPCookieInjection
            var cookie2 = new CookieHeaderValue("lastpersonname", person.Name);
            resp.Headers.AddCookies(new CookieHeaderValue[] { cookie2 });

            return resp;
        }
    }
}
