using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace NETStandaloneBlot.Other
{
    class XXE2
    {
        public void Run()
        {
            // Not vulnerable

            // CTSECNONISSUE:XMLExternalEntityParsing
            XmlDocument xd = new XmlDocument { XmlResolver = null };
            xd.Load("payload.xml");
        }
    }
}
