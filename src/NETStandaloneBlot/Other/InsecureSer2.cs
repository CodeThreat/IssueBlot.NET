using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    [Serializable]
    public class InsecureSer2
    {
        // CTSECISSUE:InsecureSerialization-Delegate
        Delegate del;
        String content;
        public InsecureSer2(Delegate del, string content)
        {
            this.del = del;
            this.content = content;
        }

        public Object SendAndSave()
        {
            return del.DynamicInvoke(content);
        }
    }

}
