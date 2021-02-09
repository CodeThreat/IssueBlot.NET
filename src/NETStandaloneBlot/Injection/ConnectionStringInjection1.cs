
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class ConnectionStringInjection1
    {
        public void Run()
        {
            string passwd = System.Console.ReadLine();

            // CTSECISSUE:ConnectionStringInjection
            using (var conn = new SqlConnection("Data Source=...User ID=abc;Password=" + passwd))
            {

            }

            using (var conn2 = new SqlConnection())
            {
                // CTSECISSUE:ConnectionStringInjection
                conn2.ConnectionString = "Data Source=...User ID=abc;Password=" + passwd;
            }

            // CTSECISSUE:ConnectionStringInjection
            using (var conn3 = new SqlConnection("Data Source=...User ID=abc;Password=" + passwd, null))
            {

            }
        }
    }
}
