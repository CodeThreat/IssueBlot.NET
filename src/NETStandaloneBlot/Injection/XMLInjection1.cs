
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace NETStandaloneBlot.Injection
{
    class XMLInjection1
    {
        public void Run()
        {
            using (XmlWriter writer = XmlWriter.Create("employees.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Employees");

                writer.WriteStartElement("Employee");

                // Characters are escaped by character entity references when possible
                // CTSECNONISSUE: XMLInjection
                writer.WriteElementString("ID", System.Console.ReadLine());
                
                // CTSECISSUE: XMLInjection
                writer.WriteRaw("<FirstName>" + System.Console.ReadLine() + "</FirstName>");
                
                writer.WriteEndElement();
            }
        }
    }
}
