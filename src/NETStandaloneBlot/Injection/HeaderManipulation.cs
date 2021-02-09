using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class HeaderManipulation
    {
        public void Run()
        {
            var author = Console.ReadLine();
            //CTSECISSUE:Header Manipulation
            Cookie cookie = new Cookie("author", author);


            String lang = Convert.ToString(Console.Read());
            WebClient client = new WebClient();
            client.BaseAddress = "";
            NameValueCollection myQueryStringCollection = new NameValueCollection();
            myQueryStringCollection.Add("q", lang);
            //CTSECISSUE: HTTP Parameter Pollution
            client.QueryString = myQueryStringCollection;
            Stream data = client.OpenRead("");

        }
    }
}
