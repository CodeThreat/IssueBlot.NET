using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class OSCommandInjection1
    {
        public void Run()
        {
            // CTSECISSUE: OSCommandInjection
            Process.Start("cmd.exe", "/C ping.exe " + System.Console.ReadLine());
        }
    }
}
