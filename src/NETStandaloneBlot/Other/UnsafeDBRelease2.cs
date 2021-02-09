using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UnsafeDBRelease2
    {
        public void Run()
        {
            try
            {
                // CTNONSECISSUE:UnsafeDatabaseResourceRelease
                using (SqlConnection conn = new SqlConnection(""))
                {
                    using (SqlCommand cmd = new SqlCommand("", conn))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                int happyCompiler = 5;
            }
        }
    }
}
