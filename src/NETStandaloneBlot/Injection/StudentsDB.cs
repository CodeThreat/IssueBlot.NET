using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Student
    {
    }
}
