using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UnsafeStreamRelease4
    {
        public void Run()
        {
            StreamReader reader = null;
            try
            {
                var request = WebRequest.Create("");
                var response = request.GetResponse();

                Stream responseStream = response.GetResponseStream();

                reader = new StreamReader(responseStream);
                var text = reader.ReadToEnd();
            }
            catch(IOException ioe)
            {
                // CTSECISSUE:UnsafeStreamResourceRelease
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
