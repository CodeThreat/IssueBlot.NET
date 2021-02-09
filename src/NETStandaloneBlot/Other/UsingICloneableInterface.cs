using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class UsingICloneableInterface : ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
