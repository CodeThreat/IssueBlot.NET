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
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')");

            using (SqlConnection con = new SqlConnection(""))
            {
                string s = System.Console.ReadLine();
                // CTSECISSUE: SQLInjection
                SqlCommand sc = new SqlCommand(s, con);
                con.Open();
                SqlDataReader DR = sc.ExecuteReader();
            }
        }
    }
}
