using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StandaloneBlot.Injection
{
    class SQLInjection1
    {
        public void Run()
        {
            using (var context = new SchoolContext())
            {
                // CTSECISSUE: SQLInjection
                var studentList = context.Students
                                    .FromSql("SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')")
                                    .ToList();
            }
        }
    }
    class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Student
    {
    }
}
