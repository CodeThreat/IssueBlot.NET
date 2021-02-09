
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class NetworkConnectionIdentifierInjection1
    {
        public void Run()
        {
            String url = "http://" + System.Console.ReadLine();
            // CTSECISSUE:NetworkConnectionIdentifierInjection
            WebRequest request = WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)request.GetResponse();
        }
    }
}
