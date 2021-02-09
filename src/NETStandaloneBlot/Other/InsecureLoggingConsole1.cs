using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class InsecureLoggingConsole1
    {
        public void Run()
        {
            // This is different than SensitiveInformationExposure1.cs.
            // Here Console.Write* is enough...

            Exception e = new Exception("");

            //CTSECISSUE:InsecureLogging-SystemOutputStream
            Console.WriteLine("ERROR: {0}", e.Message);

            //CTSECISSUE:InsecureLogging-SystemOutputStream
            Console.Write("ERROR: {0}\n", e.Message);
        }
    }
}
