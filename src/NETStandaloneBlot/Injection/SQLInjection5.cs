using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Text;


namespace NETStandaloneBlot.Injection
{
    class SQLInjection5
    {
        public void Run()
        {
            using (var context = new SchoolContext())
            {
                // CTSECISSUE: SQLInjection
                string name = System.Console.ReadLine();
                var studentList = context.Students
                                    .SqlQuery("SELECT * FROM users WHERE ( name = '" + name + "')")
                                    .ToListAsync();
            }


            using (ObjectContext studentContext = new ObjectContext("name=StudentEntities"))
            {

                string name = System.Console.ReadLine();

                // CTSECISSUE: SQLInjection
                ObjectQuery<Student> studentQuery = new ObjectQuery<Student>(name, studentContext, MergeOption.NoTracking);

                ObjectQuery<Student> studentQuery2 = new ObjectQuery<Student>("students", studentContext, MergeOption.NoTracking);

                string path = System.Console.ReadLine();
                // CTSECISSUE: SQLInjection
                IEnumerable<Student> students = studentQuery2.Include<Student>(path);

                string where = System.Console.ReadLine();
                // CTSECISSUE: SQLInjection
                ObjectQuery<Student> studentQuery4 = studentQuery2.Where(where);

                string sql = System.Console.ReadLine();
                // CTSECISSUE: SQLInjection
                studentContext.CreateQuery<Student>(sql);

                // CTSECISSUE: SQLInjection
                studentContext.CreateQuery<Student>(sql, null);
            }

            string db = System.Console.ReadLine();
            
            // CTSECISSUE: SQLInjection
            using (ObjectContext studentContext = new ObjectContext("name=" + db))
            {
                // CTSECISSUE: SQLInjection
                string name = System.Console.ReadLine();
                studentContext.ExecuteStoreCommand("SELECT * FROM users WHERE ( name = '" + name + "')");
                
                // CTSECISSUE: SQLInjection
                studentContext.ExecuteStoreCommand(TransactionalBehavior.EnsureTransaction, "SELECT * FROM users WHERE ( name = '" + name + "')", null);

                // CTSECISSUE: SQLInjection
                studentContext.ExecuteStoreCommand(TransactionalBehavior.EnsureTransaction, "SELECT * FROM users WHERE ( name = '" + name + "')", null);

                // CTSECISSUE: SQLInjection
                studentContext.ExecuteStoreQuery<Student>("SELECT * FROM users WHERE ( name = '" + name + "')");

                // CTSECISSUE: SQLInjection
                studentContext.ExecuteStoreQuery<Student>("SELECT * FROM users WHERE ( name = '" + name + "')", MergeOption.AppendOnly);

                // CTSECISSUE: SQLInjection
                studentContext.ExecuteStoreQuery<Student>("SELECT * FROM users WHERE ( name = '" + name + "')", new ExecutionOptions(MergeOption.AppendOnly, false), null);
            }
        }
    }
}
