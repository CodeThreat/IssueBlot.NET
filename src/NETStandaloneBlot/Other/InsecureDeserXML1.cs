
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace NETStandaloneBlot.Other
{
    class InsecureDeserXML1
    {
        public void Run()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(object));

            //CTSECISSUE:DirectoryTraversal
            FileStream fs = new FileStream(System.Console.ReadLine(), FileMode.OpenOrCreate);
            TextReader reader = new StreamReader(fs);

            //CTSECISSUE:InsecureDeserializationXML
            var i = (object)serializer.Deserialize(reader);
        }
    }
}
