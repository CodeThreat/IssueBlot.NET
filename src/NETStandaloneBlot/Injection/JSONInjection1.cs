
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class JSONInjection1
    {
        public void Run()
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();

                writer.WritePropertyName("username");
                writer.WriteValue("");

                writer.WritePropertyName("fullname");
                // CTSECISSUE:JSONInjection
                writer.WriteRawValue("\"" + System.Console.ReadLine() + "\"");

                writer.WriteEnd();
                writer.WriteEndObject();
            }

            string json = sb.ToString();

            // write json to disk
        }
    }
}
