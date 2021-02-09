using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NETStandaloneBlot.Authentication
{
    class BasicAuthentication1
    {
        public void Run()
        {
            var credentials = new NetworkCredential("", "");
            var credentialCache = new CredentialCache();

            // CTSECISSUE:InsecureBasicAuthentication
            credentialCache.Add("", 80, "Basic", credentials);

            // CTSECISSUE:InsecureBasicAuthentication
            credentialCache.Add(new Uri(""), "Basic", credentials);
        }
    }
}
