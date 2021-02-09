using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.Protocols;
using System.Net;
using System.Text;

namespace NETStandaloneBlot.Authentication
{
    class LDAPSimpleBind2
    {
        public void Run()
        {
            using (var context = new PrincipalContext(ContextType.Domain, ""))
            {
                var identifier = new LdapDirectoryIdentifier("", 389);
                var credential = new NetworkCredential("", "");
                var ldapConnection = new LdapConnection(identifier, credential);
                // CTSECISSUE: InsecureLDAPSimpleBind
                ldapConnection.AuthType = AuthType.Basic;
            }
        }
    }
}
