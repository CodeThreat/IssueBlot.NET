using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class EqualityWithNull1
    {
        public void Run()
        {
            var myObj = new object();

            //CTSECISSUE:IncorrectCalltoEqualswithNull
            if (myObj.Equals(null))
            {                
            }
        }
    }
}
