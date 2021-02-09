using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.ExceptionHandling
{
    class BroadException1
    {
        public void Run()
        {
            try
            {
                int x = 5;
                if (x > 1)
                {

                }
            }
            // CTSECISSUE: GenericExceptionCatchBlock
            catch (Exception e)
            {

            }
        }
    }
}
