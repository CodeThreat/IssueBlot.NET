
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;

namespace NETStandaloneBlot.Other
{
    class InsecureDeserJson1
    {
        public void Run()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                // any value other than None may lead to security problems
                // CTSECISSUE:InsecureDeserialization-Json
                TypeNameHandling = TypeNameHandling.All
            };

            var obj = JsonConvert.DeserializeObject<User>(System.Console.ReadLine(), settings);
        }
    }

    class User
    {

    }
}
