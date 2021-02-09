using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace NETStandaloneBlot.Other
{
    class XXE1
    {
        public void Run()
        {
            // Possibly vulnerable if (Target Framework < 4.5.2)

            // CTSECISSUE:XMLExternalEntityParsing
            XmlDocument xd = new XmlDocument();
            xd.Load("payload.xml");
        }
    }
}
