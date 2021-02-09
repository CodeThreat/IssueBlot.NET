using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class OSCommandInjection2
    {
        public void Run()
        {
            var process = new Process
            {
                // CTSECISSUE: OSCommandInjection
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = System.Console.ReadLine(),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            // CTSECISSUE: OSCommandInjection
            var startInfo = new ProcessStartInfo
            {
                FileName = System.Console.ReadLine(),
                Arguments = "",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            startInfo = new ProcessStartInfo();
            // CTSECISSUE: OSCommandInjection
            startInfo.FileName = System.Console.ReadLine();
            startInfo.Arguments = "cmd.exe";

            startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            // CTSECISSUE: OSCommandInjection
            startInfo.Arguments = System.Console.ReadLine();

            // CTSECISSUE: OSCommandInjection
            startInfo = new ProcessStartInfo(System.Console.ReadLine(), "");

            // CTSECISSUE: OSCommandInjection
            startInfo = new ProcessStartInfo("", System.Console.ReadLine());
        }
    }
}
