using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Win32;

namespace NETStandaloneBlot.Other
{
    class RegistryManipulation1
    {
        public void Run()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);

            key.CreateSubKey("MyAppName");
            key = key.OpenSubKey("MyAppName", true);

            key.CreateSubKey("UserOption");
            key = key.OpenSubKey("UserOption", true);

            // CTSECISSUE: RegistryManipulation
            key.SetValue("option1", System.Console.ReadLine());

            // CTSECISSUE: RegistryManipulation
            key.SetValue("option2", System.Console.ReadLine(), RegistryValueKind.String);
        }
    }
}
