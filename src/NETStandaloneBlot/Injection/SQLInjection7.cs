
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class SQLInjection7
    {
        public void Run()
        {
            var cfg = new Configuration();
            cfg.Configure();
            var sessionFactory = cfg.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            // CTSECISSUE:NHibernateSQLInjection
            var query = session.CreateQuery("from users where name ='" + System.Console.ReadLine() + "'");
        }
    }
}
