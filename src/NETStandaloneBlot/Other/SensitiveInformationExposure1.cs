using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class SensitiveInformationExposure1
    {
        public void Run()
        {
            // Console.Write or Console.WriteLine has 17 overloaded methods

            // CTSECISSUE:SensitiveInformationExposure
            Console.Write("Logical Drives:" + string.Join("-", Environment.GetLogicalDrives()));

            // CTSECISSUE:SensitiveInformationExposure
            Console.WriteLine("Logical Drives:" + string.Join("-", Environment.GetLogicalDrives()));
        }
    }
}
