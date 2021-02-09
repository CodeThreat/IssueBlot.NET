using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.DirectoryServices;
using System.Text;



namespace NETStandaloneBlot.Injection
{
    class LDAPInjection2
    {
        public void Run()
        {
            string[] prop = new string[1] { "" };

            //System.DirectoryServices.DirectoryEntry

            string filter = "cn: " + System.Console.ReadLine();

            // CTSECISSUE: LDAPInjection
            DirectorySearcher ds = new DirectorySearcher(System.Console.ReadLine());

            // CTSECISSUE: LDAPInjection
            DirectorySearcher ds2 = new DirectorySearcher(filter);

            // CTSECISSUE: LDAPInjection
            DirectorySearcher ds3 = new DirectorySearcher(new DirectoryEntry("", "", ""), filter);

            // CTSECISSUE: LDAPInjection
            DirectorySearcher ds4 = new DirectorySearcher(new DirectoryEntry("", "", ""), filter, prop);

            // CTSECISSUE: LDAPInjection
            DirectorySearcher ds5 = new DirectorySearcher(new DirectoryEntry("", "", ""), filter, prop, SearchScope.OneLevel);

            // CTSECISSUE: LDAPInjection
            DirectorySearcher ds6 = new DirectorySearcher(filter, prop);

            // CTSECISSUE: LDAPInjection
            DirectorySearcher ds7 = new DirectorySearcher(filter, prop, SearchScope.Subtree);

            // CTSECISSUE: LDAPInjection
            ds.Filter = "(&(objectClass=user)(name=" + System.Console.ReadLine() + ")";
            SearchResultCollection results = ds.FindAll();
        }
    }
}
