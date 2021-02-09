using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Text;



namespace NETStandaloneBlot.Injection
{
    class SQLInjection6
    {
        public void Run()
        {
            using (var context = new StudentContext())
            {
                // CTSECISSUE: SQLInjection
                var gradeList = context.Database.ExecuteSqlCommand("SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')");
            }

            using (var context = new StudentContext())
            {
                // CTSECISSUE: SQLInjection
                var gradeList = context.Database.ExecuteSqlCommandAsync("SELECT * FROM users WHERE ( name = '" + System.Console.ReadLine() + "')").Result;
            }
        }
    }

    class StudentContext : DbContext
    {
        //public StudentContext() : base("StudentDB")
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentContext, NETStandaloneBlot.Migrations.Configuration>());
        //}

        public DbSet<Grade> Grades { get; set; }
    }

    class Grade
    {
    }
}
