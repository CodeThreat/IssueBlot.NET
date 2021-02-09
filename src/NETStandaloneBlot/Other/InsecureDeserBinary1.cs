
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class InsecureDeserBinary1
    {
        public void Run()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            //CTSECISSUE:DirectoryTraversal
            byte[] content = File.ReadAllBytes(System.Console.ReadLine());
            MemoryStream ms = new MemoryStream(content);

            //CTSECISSUE:InsecureDeserialization-Binary
            var i = (object)serializer.Deserialize(ms);
        }
    }
}
