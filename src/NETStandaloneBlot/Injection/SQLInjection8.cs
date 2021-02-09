using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class SQLInjection8
    {
        public void Run()
        {
            var cn = new SqliteConnection("");

            try
            {
                cn.Open();
                // CTSECISSUE:SqlInjection
                var cmd = new SqliteCommand("select count(*) from Users where ID = " + System.Console.ReadLine(), cn);
                string result = cmd.ExecuteScalar().ToString();
            }
            finally
            {
                if (cn.State != System.Data.ConnectionState.Closed) 
                { 
                    cn.Close(); 
                }
            }
        }
    }
}
