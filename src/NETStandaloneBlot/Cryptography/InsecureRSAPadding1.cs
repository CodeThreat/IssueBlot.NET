
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class InsecureRSAPadding1
    {
        public void Run()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            // CTSECISSUE:InsecureRSAPadding
            rsa.Encrypt(new byte[] { }, false);
        }
    }
}
