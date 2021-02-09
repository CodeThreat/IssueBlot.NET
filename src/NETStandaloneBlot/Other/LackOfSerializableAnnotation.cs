using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class LackOfSerializableAnnotation
    {
        // CTSECISSUE:LackOfSerializableAnnotation
        public class RemoteMessage : ISerializable
        {
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }
        }


        // CTNONSECISSUE:LackOfSerializableAnnotation
        [Serializable]
        public class NonRemoteMessage : ISerializable
        {
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }
        }
    }
}
