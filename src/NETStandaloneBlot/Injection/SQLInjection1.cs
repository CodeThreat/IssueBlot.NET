using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class SQLInjection1
    {
        public void Run()
        {
            using (SqlConnection con = new SqlConnection(""))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = con;
                // CTSECISSUE: SQLInjection
                sqlComm.CommandText = "SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')";
                con.Open();
                SqlDataReader DR = sqlComm.ExecuteReader();
            }

            using (SqlConnection con = new SqlConnection(""))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = con;
                // CTSECISSUE: SQLInjection
                // CTSECISSUE: Insecure Database Administrative Mechanism
                sqlComm.CommandText = System.Console.ReadLine();
                con.Open();
                SqlDataReader DR = sqlComm.ExecuteReader();
            }
        }    
    }
}
