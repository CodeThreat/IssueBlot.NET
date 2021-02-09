
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace NETStandaloneBlot.Injection
{
    class NetworkConnectionIdentifierInjection3
    {
        public void Run()
        {
            String url = "http://" + System.Console.ReadLine();

            using (var client = new WebClient())
            {
                // CTSECISSUE:NetworkConnectionIdentifierInjection
                var response1 = client.UploadValues(url, new NameValueCollection());

                // CTSECISSUE:NetworkConnectionIdentifierInjection
                var response2 = client.UploadValues(url, "POST", new NameValueCollection());

                // CTSECISSUE:NetworkConnectionIdentifierInjection
                var response3 = client.DownloadString(url);
            }
        }
    }
}
