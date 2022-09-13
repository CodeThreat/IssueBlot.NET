
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class InsecureHash1
    {
        public void Run()
        {
            // CTSECISSUE:InsecureCryptographicHash
            var md5 = new MD5CryptoServiceProvider();
            var hashValue = md5.ComputeHash(new byte[] { });

            // CTSECISSUE:InsecureCryptographicHash
            var hmacmd5 = new HMACMD5();
            hashValue = hmacmd5.ComputeHash(new byte[] { });

            // CTSECISSUE:InsecureCryptographicHash
            var sha1 = new SHA1CryptoServiceProvider();
            hashValue = sha1.ComputeHash(new byte[] { });

            // CTSECISSUE:InsecureCryptographicHash
            var sha1Managed = new SHA1Managed();
            hashValue = sha1Managed.ComputeHash(new byte[] { });

            // CTSECISSUE:InsecureCryptographicHash
            var sha2 = new SHA256CryptoServiceProvider();
            hashValue = sha2.ComputeHash(new byte[] { });

            // CTSECISSUE:InsecureCryptographicHash
            var sha2Managed = new SHA256Managed();
            hashValue = sha2Managed.ComputeHash(new byte[] { });


            // CTSECISSUE:InsecureCryptographicHash 2
            var sha2Managedsecond = new SHA256Managed();
            hashValue = sha2Managed.ComputeHash(new byte[] { });

            // CTSECISSUE:InsecureCryptographicHash3 
            var sha3Managedsecond = new SHA256Managed();
            hashValue = sha2Managed.ComputeHash(new byte[] { });
        }
    }
}
