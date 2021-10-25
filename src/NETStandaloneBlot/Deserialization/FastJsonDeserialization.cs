using fastJSON;
using MBrace.FsPickler.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NETStandaloneBlot.Other
{
    public class FastJsonDeserialization
    {
        public void FastJSONDeserialization(string json)
        {
            try
            {
                // ruleid: insecure-fastjson-deserialization
                var obj = JSON.ToObject(json, new JSONParameters { BadListTypeChecking = false});
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void FsPicklerDeserialization(string json)
        {
            try
            {
                // ruleid: insecure-fspickler-deserialization
                var fsPickler = FsPickler.CreateJsonSerializer();
                MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(json));
                fsPickler.Deserialize<object>(memoryStream);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void NewtonsoftDeserialization(string json)
        {
            try
            {
                // ruleid: insecure-newtonsoft-deserialization
                JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                    
                });
                JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Arrays

                });
                JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto

                });
                JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects

                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
