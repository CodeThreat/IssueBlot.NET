using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class SQLInjection10
    { 
        public void Run()
        {

            using (SqlConnection con = new SqlConnection(""))
            {
                // CTSECISSUE: SQLInjection
                SqlCommand sc = new SqlCommand("SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')", con);
                con.Open();
                SqlDataReader DR = sc.ExecuteReader();
            }
        }
    }
}
