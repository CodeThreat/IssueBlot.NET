using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UnsafeDBRelease3
    {
        public void Run()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn = new SqlConnection("");
                cmd = new SqlCommand("", conn);
                rdr = cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                int happyCompiler = 5;
            }
            finally
            {
                // CTSECISSUE:UnsafeDatabaseResourceRelease
                rdr.Close();
                // CTSECISSUE:UnsafeDatabaseResourceRelease
                cmd.Dispose();
                // CTSECISSUE:UnsafeDatabaseResourceRelease
                conn.Close();
            }

        }
    }
}
