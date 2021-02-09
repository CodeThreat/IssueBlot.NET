using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class CustomSSLValidation1
    {
        public bool vsc(object sender,
                      X509Certificate certificate,
                      X509Chain chain,
                      SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public void Run()
        {
            WebRequest request = WebRequest.Create("https://www.selfsigned.com");

            // CTSECISSUE: CustomSSLValidation
            ServicePointManager.ServerCertificateValidationCallback +=
               new RemoteCertificateValidationCallback(vsc);

        }
    }
}
