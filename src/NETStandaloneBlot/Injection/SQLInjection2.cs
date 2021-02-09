using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class SQLInjection2
    {
        public void Run()
        {
            string commandText = "SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')";

            using (SqlConnection connection =
                    new SqlConnection(""))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                // CTSECISSUE: SQLInjection
                adapter.SelectCommand = new SqlCommand(commandText, connection);
            }
        }
    }
}
