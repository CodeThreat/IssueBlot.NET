
using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class ExecutableInjection1
    {
        public void Run()
        {
            AppDomain aDomain = AppDomain.CreateDomain("aDomain");

            // CTSECISSUE:ExecutableInjection:High
            var ret1 = aDomain.ExecuteAssembly("C:\\" + System.Console.ReadLine());

            // CTSECISSUE:ExecutableInjection:Low
            var ret2 = aDomain.ExecuteAssembly("C:\\test.dll");
        }
    }
}
