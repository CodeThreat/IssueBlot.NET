using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace NETStandaloneBlot.Injection
{
    class OSCommandInjection4
    {
        public static async Task Main(string[] args)
        {
            // CTSECISSUE: OSCommandInjection
            Process.Start("cmd.exe", "/C ping.exe " + args[0]);
        }
    }
}
