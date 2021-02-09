using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class CustomSSLValidation2
    {

        public void Run()
        {
            using (var handler = new WebRequestHandler())
            {
                // CTSECISSUE: CustomSSLValidation
                handler.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                using (var client = new HttpClient(handler))
                {
                    var request = client.GetStringAsync("url");
                }
            }
        }
    }
}
