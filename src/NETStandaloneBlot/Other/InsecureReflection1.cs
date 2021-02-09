
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class InsecureReflection1
    {
        public void Run()
        {
            string input = System.Console.ReadLine();

            // CTSECISSUE: InsecureReflection
            Assembly testAssembly = Assembly.LoadFile(input);

            Type calcType = testAssembly.GetType(input);

            // CTSECISSUE: InsecureReflection
            object calcInstance = Activator.CreateInstance(calcType);
            
            MethodInfo method = calcInstance.GetType().GetMethod(input);
            // CTSECISSUE: InsecureReflection
            method.Invoke(calcInstance, new object[] { input });
        }
    }
}
