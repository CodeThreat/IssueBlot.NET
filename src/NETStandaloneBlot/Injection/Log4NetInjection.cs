
using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class Log4NetInjection
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Run()
        {
            //CTSECISSUE:Log4netForging
            logger.Warn("Failed authentication for: " + System.Console.ReadLine());
        }
    }
}
