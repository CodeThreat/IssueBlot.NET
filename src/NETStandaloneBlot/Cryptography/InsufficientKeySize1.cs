
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class InsufficientKeySize1
    {
        public void Run()
        {
            // CTSECISSUE:InsufficientEncryptionKeySize
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.Encrypt(new byte[] { }, false);
        }
    }
}
