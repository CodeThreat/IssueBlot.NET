using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Text;

namespace NETStandaloneBlot.Authentication
{
    class LDAPSimpleBind1
    {
        public void Run()
        {
            using (var context = new PrincipalContext(ContextType.Domain, ""))
            {
                // CTSECISSUE: InsecureLDAPSimpleBind
                context.ValidateCredentials("", "",
                                             ContextOptions.SimpleBind | ContextOptions.Negotiate);
            }
        }
    }
}
