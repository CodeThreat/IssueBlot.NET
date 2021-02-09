using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class ManualGarbageCollection1
    {
        public void Run()
        {
            // CTSECISSUE: UseOfManualGarbageCollect
            System.GC.Collect();
        }
    }
}
