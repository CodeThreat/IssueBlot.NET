using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class SQLInjection3
    {
        public void Run()
        {
            using (SqlConnection con = new SqlConnection(""))
            {
                string commandText = "SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')";
                // CTSECISSUE: SQLInjection
                SqlCommand sqlComm = new SqlCommand(commandText, con);
                con.Open();
                SqlDataReader DR = sqlComm.ExecuteReader();
            }
        }
    }
}
