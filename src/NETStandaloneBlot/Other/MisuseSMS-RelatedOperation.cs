using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NETStandaloneBlot.Other
{
    class MisuseSMS_RelatedOperation
    {
        void SMS_Clicked(object sender, System.EventArgs e)
        {
            // CTSECISSUE: Misuse SMS-Related Operation
            Device.OpenUri(new Uri("sms:+12345678910"));
        }

    }
}
