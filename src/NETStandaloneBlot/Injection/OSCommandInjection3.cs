using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class OSCommandInjection3
    {
        static void Main(string[] args)
        {
            // CTSECISSUE: OSCommandInjection
            Process.Start("cmd.exe", "/C ping.exe " + args[0]);
        }
    }
}
