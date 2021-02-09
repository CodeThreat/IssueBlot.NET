using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NETStandaloneBlot.Other
{
    class MaliciousAPIUsage1
    {
        public void Run()
        {
            // CTSECISSUE: MaliciousAPIUsage
            Process.Start("cmd.exe", "/C ping.exe 127.0.0.1");
        }
    }
}
