using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace NETStandaloneBlot.Other
{
    class MaliciousAPIUsage3
    {
        public void Run()
        {
            // CTSECISSUE: MaliciousAPIUsage
            var inst = Activator.CreateInstance(typeof(MaliciousAPIUsage3), null);

            // CTSECISSUE: MaliciousAPIUsage
            var assembly = Assembly.LoadFile(@"test.dll");

            Assembly info = typeof(System.Int32).Assembly;
            // CTSECISSUE: MaliciousAPIUsage
            info.CreateInstance("");
        }
    }
}
