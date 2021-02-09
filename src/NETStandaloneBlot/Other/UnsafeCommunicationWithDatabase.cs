using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class UnsafeCommunicationWithDatabase
    {
        // CTSECISSUE:Unsafe Communication With Database
        SqlConnection DBconnUnsafe = new SqlConnection("Data Source=10.10.10.10,1433; Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;");
        // CTNONSECISSUE:Unsafe Communication With Database
        SqlConnection DBconnSafe = new SqlConnection("Initial Catalog = emp_test; Persist Security Info=True;User ID = myUsername; Password=myPassword;Data Source = 10.10.10.10; Provider=SQLOLEDB;Use Encryption for Data=True;Trust Server Certificate=True;");

        public void Run()
        {
            Console.WriteLine(DBconnUnsafe);
            Console.Write(DBconnUnsafe);
        }
    }
}
