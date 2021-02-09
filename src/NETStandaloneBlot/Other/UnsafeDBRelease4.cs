using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UnsafeDBRelease4
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
                if (rdr != null)
                {
                    // CTSECISSUE:UnsafeDatabaseResourceRelease
                    rdr.Close();
                }

                if (cmd != null)
                {
                    // CTSECISSUE:UnsafeDatabaseResourceRelease
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    // CTSECISSUE:UnsafeDatabaseResourceRelease
                    conn.Close();
                }
            }

        }
    }
}
