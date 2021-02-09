using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UnsafeStreamRelease1
    {
        public void Run()
        {
            var request = WebRequest.Create("");
            var response = request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            var text = reader.ReadToEnd();

            // CTSECISSUE:UnsafeStreamResourceRelease
            reader.Close();

            // CTSECISSUE:UnsafeStreamResourceRelease
            response.Close();
        }
    }
}
