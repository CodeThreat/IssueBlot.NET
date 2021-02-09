using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace NETStandaloneBlot.Other
{
    class XXE3
    {
        public void Run()
        {
            // Not vulnerable

            // CTSECNONISSUE:XMLExternalEntityParsing
            XmlDocument xd = new XmlDocument { };
            Secure(xd);
            xd.Load("payload.xml");
        }

        private void Secure(XmlDocument xd)
        {
            xd.XmlResolver = null;
        }
    }
}
