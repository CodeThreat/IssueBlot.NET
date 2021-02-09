using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.ExceptionHandling
{
    class CatchingNullReference1
    {
        public void Run()
        {
            // CTSECISSUE:CatchingNullReferenceException
            try
            {
                string s = String.Empty;
                s = s.Substring(5, 7);
            }
            catch (NullReferenceException nre)
            {
            }
        }
    }
}
