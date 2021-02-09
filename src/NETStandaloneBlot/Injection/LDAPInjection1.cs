using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.DirectoryServices;
using System.Text;



namespace NETStandaloneBlot.Injection
{
    class LDAPInjection1
    {
        public void Run()
        {
            // CTSECISSUE: LDAPResourceInjection
            DirectoryEntry entry1 = new DirectoryEntry("LDAP://myintra.corp:389/" + System.Console.ReadLine() + "/", "", "");

            // CTSECISSUE: LDAPResourceInjection
            DirectoryEntry entry2 = new DirectoryEntry("LDAP://myintra.corp:389/" + System.Console.ReadLine() + "/", "", "", AuthenticationTypes.Anonymous);

            // CTSECISSUE: LDAPResourceInjection
            DirectoryEntry entry3 = new DirectoryEntry("LDAP://myintra.corp:389/" + System.Console.ReadLine() + "/");
            entry3.AuthenticationType = AuthenticationTypes.SecureSocketsLayer;
            DirectorySearcher searcher = new DirectorySearcher(entry3, "");

            DirectoryEntry entry4 = new DirectoryEntry();
            // CTSECISSUE: LDAPResourceInjection
            entry4.Path = "" + System.Console.ReadLine();
        }
    }
}
