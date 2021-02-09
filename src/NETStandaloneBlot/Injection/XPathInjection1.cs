
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace NETStandaloneBlot.Injection
{
    class XPathInjection1
    {
        public void Run()
        {
            XmlDocument XmlDoc = new XmlDocument();
            // Possibly vulnerable if (Target Framework < 4.5.2)

            // CTSECISSUE:XMLExternalEntityParsing
            XmlDoc.Load("books.xml");

            XPathNavigator nav = XmlDoc.CreateNavigator();
            // CTSECISSUE:XPathInjection
            String xPath = "//book/title[text()='" + System.Console.ReadLine() + "']/text()";

            XPathExpression e = nav.Compile(xPath);
            var nodeSet = (XPathNodeIterator)nav.Evaluate(e);
        }
    }
}
