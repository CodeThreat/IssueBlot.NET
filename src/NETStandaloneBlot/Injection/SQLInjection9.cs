using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class SQLInjection9
    {
        public void Run()
        {
            var cn = new SqliteConnection("");

            int id;

            if (!Int32.TryParse(System.Console.ReadLine(), out id))
            {
                return;
            }
            
            try
            {
                cn.Open();
                // CTNONSECISSUE:SqlInjection
                var cmd = new SqliteCommand("select count(*) from Users where ID = " + id.ToString(), cn);
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
