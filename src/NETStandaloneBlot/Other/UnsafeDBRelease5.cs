using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UnsafeDBRelease5
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
                    try
                    {
                        // CTNONSECISSUE:UnsafeDatabaseResourceRelease
                        rdr.Close();
                    }
                    catch (SqlException se)
                    {
                        int happyCompiler = 5;
                    }
                }

                if (cmd != null)
                {
                    try {
                        // CTNONSECISSUE:UnsafeDatabaseResourceRelease
                        cmd.Dispose();
                    }
                    catch (SqlException se)
                    {
                        int happyCompiler = 5;
                    }

                }

                if (conn != null)
                {
                    try { 
                        // CTNONSECISSUE:UnsafeDatabaseResourceRelease
                        conn.Close();
                    }
                    catch (SqlException se)
                    {
                        int happyCompiler = 5;
                    }
                }
            }

        }
    }
}
