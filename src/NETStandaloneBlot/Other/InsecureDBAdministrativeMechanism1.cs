using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace NETStandaloneBlot.Other
{
    class InsecureDBAdministrativeMechanism1
    {
        public void Run()
        {
            // CTSECISSUE: InsecureDatabaseAdministrativeMechanism
            SqlConnection con = new SqlConnection("");
            SqlCommand sqlComm = new SqlCommand(System.Console.ReadLine());
            sqlComm.Connection = con;
            con.Open();
            SqlDataReader DR = sqlComm.ExecuteReader();
        }
    }
}
