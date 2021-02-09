using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class OSCommandInjection5
    {
        static void Main()
        {
            string[] arguments = Environment.GetCommandLineArgs();
            // CTSECISSUE: OSCommandInjection
            Process.Start("cmd.exe", "/C ping.exe " + arguments[0]);
        }
    }
}
