using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    // The class is serializable, however, NOT extend IDeserializationCallback 

    // CTSECISSUE:InadequateDeserializationValidation
    [Serializable]
    class InadequateDeserValidation1
    {
    }
}
