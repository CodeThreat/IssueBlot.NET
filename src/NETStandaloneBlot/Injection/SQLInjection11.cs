using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq.Dynamic;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class SQLInjection11
    { 
        public void Run()
        {
            using (var context = new SchoolContext())
            {
                // CTSECISSUE: SQLInjection
                string name = System.Console.ReadLine();
                var studentList = context.Students.Where(name);

                // CTSECISSUE: SQLInjection
                var studentList2 = context.Students.Where<Student>(name);

                // CTSECISSUE: SQLInjection
                var studentList3 = context.Students.Select(name);

                // CTSECISSUE: SQLInjection
                var studentList4 = context.Students.OrderBy<Student>("asc " + name, null);
            }
        }
    }


}
