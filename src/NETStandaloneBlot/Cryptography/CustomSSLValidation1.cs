using Azure.Storage.Queues;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{

    class CustomSSLValidation1
    {
        private static CloudStorageAccount storageAccount;
        private static CloudQueue urlQueue;
      
        public bool vsc(object sender,
                      X509Certificate certificate,
                      X509Chain chain,
                      SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public void Run()
        {
            UdpClient udpClient = new UdpClient(11000);
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            WebRequest request = WebRequest.Create("https://www.selfsigned.com");

            // CTSECISSUE: CustomSSLValidation
            ServicePointManager.ServerCertificateValidationCallback +=
               new RemoteCertificateValidationCallback(vsc);
            Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

            
        }
       
    }
}
