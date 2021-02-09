
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
            using (var pbkdf2 = new Rfc2898DeriveBytes("", new byte[] { }, workFactor, HashAlgorithmName.MD5))
            {
                var key = pbkdf2.GetBytes(64);
            }

            // CTSECISSUE:InsecureCryptographicHash
            using (var pbkdf2 = new Rfc2898DeriveBytes("", new byte[] { }, workFactor, HashAlgorithmName.SHA1))
            {
                var key = pbkdf2.GetBytes(64);
            }

            // CTNONSECISSUE:InsecureCryptographicHash
            using (var pbkdf2 = new Rfc2898DeriveBytes("", new byte[] { }, workFactor, HashAlgorithmName.SHA256))
            {
                var key = pbkdf2.GetBytes(64);
            }
        }
    }
}
