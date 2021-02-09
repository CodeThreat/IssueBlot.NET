
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class InsecureDirectObjectReference1
    {
        public void Run()
        {
            string productIdStr = System.Console.ReadLine();
            int productId = Int32.Parse(productIdStr);

            var cfg = new Configuration();
            cfg.Configure();
            var sessionFactory = cfg.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            // CTSECISSUE:InsecureDirectObjectReference
            var query = session.Get<Product>(productId);

        }

    }

    public class Product
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}
