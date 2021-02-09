using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class NlogForging
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void Run()
        {
            // CTSECISSUE:Nlog Forging
            logger.Warn("Failed authentication for: " + System.Console.ReadLine());

        }
    }
}
