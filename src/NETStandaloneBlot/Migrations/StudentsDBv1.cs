using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Sql;
using System.Text;

namespace NETStandaloneBlot.Migrations
{
    class StudentsDBv1 : DbMigration
    {

        public override void Up()
        {
            // CTSECISSUE: SQLInjection
            Sql(@"  ALTER DATABASE CURRENT
                SET READ_COMMITTED_SNAPSHOT ON " + System.Console.ReadLine(), true);

            // CTSECISSUE: SQLInjection
            RenameColumn(System.Console.ReadLine(), "mycol", "renamedcol");
        }

        public override void Down()
        {
            var sql = System.Console.ReadLine();
            var statements = new List<MigrationStatement>
            {
                new MigrationStatement
                {
                    // CTSECISSUE: SQLInjection
                    Sql = "ALTER DATABASE CURRENT SET READ_COMMITTED_SNAPSHOT ON " + sql ,
                    SuppressTransaction = true
                },
            };

            sql = System.Console.ReadLine();
            // CTSECISSUE: SQLInjection
            AddColumn("dbo.Students", "Student", c => c.Binary(defaultValueSql:sql));

            // CTSECISSUE: SQLInjection
            AddColumn("dbo.Students", "Student", c => c.String(defaultValueSql:sql));

            base.Down();
        }
    }
}
