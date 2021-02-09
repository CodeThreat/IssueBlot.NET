using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UnsafeStreamRelease2
    {
        public void Run()
        {
            var request = WebRequest.Create("");
            var response = request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            
            // CTNONSECISSUE:UnsafeStreamResourceRelease
            using (StreamReader reader = new StreamReader(responseStream))
            {
                var text = reader.ReadToEnd();
            }
        }
    }
}
