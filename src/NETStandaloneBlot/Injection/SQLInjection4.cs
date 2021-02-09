using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace NETStandaloneBlot.Injection
{
    class SQLInjection4
    {
        public void Run()
        {
            ServerConnection sc = new ServerConnection();
            sc.ConnectionString = "";
            Server server = new Server(sc);
            string commandText = "SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')";
            // CTSECISSUE: SQLInjection
            server.ConnectionContext.ExecuteNonQuery(commandText);
            server.ConnectionContext.CommitTransaction();
            server.ConnectionContext.Disconnect();
        }
    }
}
