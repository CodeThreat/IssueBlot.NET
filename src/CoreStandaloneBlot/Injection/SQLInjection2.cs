using Microsoft.EntityFrameworkCore;

namespace StandaloneBlot.Injection
{
    class SQLInjection2
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
        public DbSet<Grade> Grades { get; set; }
    }

    class Grade
    {
    }
}
