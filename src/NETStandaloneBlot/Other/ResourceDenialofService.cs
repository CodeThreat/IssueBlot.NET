using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NETStandaloneBlot.Other
{
    class ResourceDenialofService
    {
        public void Run()
        {
            int value = Convert.ToInt32(System.Console.ReadLine());
            // CTSECISSUE:ResourceDenialofService
            Thread.Sleep(value);
        }
    }
}
