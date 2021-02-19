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
                // CTSECISSUE: InsecureDatabaseAdministrativeMechanism
                sqlComm.CommandText = System.Console.ReadLine();
                con.Open();
                SqlDataReader DR = sqlComm.ExecuteReader();
            }

            using (SqlConnection con = new SqlConnection(""))
            {
                // possible sql injection, if SP_GetVuln uses dynamically constructed sql queries

                SqlCommand cmd = new SqlCommand("EXEC SP_GetVuln @sID", con);
                // CTSECISSUE: SQLInjection
                cmd.Parameters.Add(new SqlParameter("@sID", System.Console.ReadLine()));
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader rdr = cmd.ExecuteReader();                
            }


            using (SqlConnection con = new SqlConnection(""))
            {
                // possible sql injection, if SP_GetVuln uses dynamically constructed sql queries
                SqlCommand cmd = new SqlCommand("SP_GetVuln", con);
                // CTSECISSUE: SQLInjection
                cmd.Parameters.Add(new SqlParameter("@sID", System.Console.ReadLine()));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
            }
        }
    }
}
