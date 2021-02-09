
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class NlogInjection
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void Run()
        {
            //CTSECISSUE:NLogForging
            logger.Warn("Failed authentication for: " + System.Console.ReadLine());
        }
    }
}
