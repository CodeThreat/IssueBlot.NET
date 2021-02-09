
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace NETStandaloneBlot.Injection
{
    class XMLInjection2
    {
        public void Run()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("users");
            xmlDoc.AppendChild(rootNode);

            XmlNode userNode = xmlDoc.CreateElement("user");

            // Text containing<markup/> will have char(<) and char(>) escaped.
            // CTSECNONISSUE:XMLInjection 
            userNode.InnerText = System.Console.ReadLine();
            rootNode.AppendChild(userNode);

            xmlDoc.Save("users.xml");
        }
    }
}
