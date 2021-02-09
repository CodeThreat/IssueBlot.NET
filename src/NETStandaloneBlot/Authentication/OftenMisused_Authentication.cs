using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NETStandaloneBlot.Authentication
{
    class OftenMisused_Authentication
    {
        public void Run()
        {
            IPAddress hostIPAddress = IPAddress.Parse("");
            // CTSECISSUE: OftenMisused_Authentication
            IPHostEntry hostInfo = Dns.GetHostByAddress(hostIPAddress);
            if (hostInfo.HostName.StartsWith("trustme.com"))
            {
               bool trusted = true;
            }
        }
    }
}
