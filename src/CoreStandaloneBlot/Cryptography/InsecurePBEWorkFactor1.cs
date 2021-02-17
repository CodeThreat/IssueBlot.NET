
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CoreStandaloneBlot.Cryptography
{
    class InsecurePBEWorkFactor1
    {
        public void Run()
        {
            int workFactor = 8000;
            // CTSECISSUE:InsecureCryptographicHash
            /* FLOW:Insecure Crypto Hash - Rfc2898DeriveBytes MD5:insecure.cryptographic.hash:0+:FIND_ISSUE:1:
            */
            using (var pbkdf2 = new Rfc2898DeriveBytes("", new byte[] { }, workFactor, HashAlgorithmName.MD5))
            {
                var key = pbkdf2.GetBytes(64);
            }

            // CTSECISSUE:InsecureCryptographicHash
            /* FLOW:Insecure Crypto Hash - Rfc2898DeriveBytes SHA1:insecure.cryptographic.hash:0+:FIND_ISSUE:1:
            */
            using (var pbkdf2 = new Rfc2898DeriveBytes("", new byte[] { }, workFactor, HashAlgorithmName.SHA1))
            {
                var key = pbkdf2.GetBytes(64);
            }

            // CTNONSECISSUE:InsecureCryptographicHash
            /* FLOW:Insecure Crypto Hash - Rfc2898DeriveBytes SHA256:insecure.cryptographic.hash:0:NONE:1:
            */
            using (var pbkdf2 = new Rfc2898DeriveBytes("", new byte[] { }, workFactor, HashAlgorithmName.SHA256))
            {
                var key = pbkdf2.GetBytes(64);
            }
        }
    }
}
