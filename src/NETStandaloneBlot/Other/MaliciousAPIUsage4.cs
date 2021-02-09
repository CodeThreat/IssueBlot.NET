using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Net.Mail;

namespace NETStandaloneBlot.Other
{
    class MaliciousAPIUsage4
    {
        public void Run()
        {
            // CTSECISSUE: MaliciousAPIUsage
            SmtpClient client = new SmtpClient("Host");
        }
    }
}
