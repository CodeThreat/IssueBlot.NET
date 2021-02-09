using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UnsafeDBRelease1
    {
        public void Run()
        {

            try
            {
                SqlConnection conn = new SqlConnection("");
                SqlCommand cmd = new SqlCommand("");
                cmd.Connection = conn;
                SqlDataReader rdr = cmd.ExecuteReader();
                // CTSECISSUE:UnsafeDatabaseResourceRelease
                rdr.Close();
                // CTSECISSUE:UnsafeDatabaseResourceRelease
                cmd.Dispose();
                // CTSECISSUE:UnsafeDatabaseResourceRelease
                conn.Close();
            }
            catch (SqlException e)
            {
                int happyCompiler = 5;
            }
        }
    }
}
