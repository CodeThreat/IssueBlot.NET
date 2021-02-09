
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace NETStandaloneBlot.Injection
{
    class NetworkConnectionIdentifierInjection2
    {
        public void Run()
        {
            String url = "http://" + System.Console.ReadLine();

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            Uri uri = new Uri(url);

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);

            HttpClient client = new HttpClient();

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            var response = client.GetAsync(url).Result;

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            response = client.GetAsync(url, new CancellationToken()).Result;

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            response = client.PostAsync(url, new StringContent("")).Result;

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            response = client.PostAsync(url, new StringContent(""), new CancellationToken()).Result;

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            response = client.DeleteAsync(url).Result;

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            response = client.DeleteAsync(url, new CancellationToken()).Result;

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            response = client.PutAsync(url, new StringContent("")).Result;

            // CTSECISSUE:NetworkConnectionIdentifierInjection
            response = client.PutAsync(url, new StringContent(""), new CancellationToken()).Result;
        }
    }
}
