using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    [Serializable]
    public class InsecureSer1
    {
        // CTSECISSUE:InsecureSerialization-Delegate
        event EventHandler<ContentEventArgs> OnRun;
        String content;
        public InsecureSer1(string content)
        {
            this.content = content;
        }

        public void SendAndSave()
        {
            ContentEventArgs contentEventArgs = new ContentEventArgs() { Content = content };
            OnRun(this, contentEventArgs);
        }
    }

    public class ContentEventArgs : EventArgs
    {
        public String Content { get; set; }
    }
}
