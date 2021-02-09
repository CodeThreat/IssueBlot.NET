
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class InsecurePBEWorkFactor1
    {
        public void Run()
        {
            int workFactor = 2000;
            // CTSECISSUE:InsecurePBEWorkFactor
            using (var pbkdf2 = new Rfc2898DeriveBytes("", new byte[] { }, workFactor))
            {
                var key = pbkdf2.GetBytes(64);
            }

            // CTSECISSUE:InsecurePBEWorkFactor
            using (var pbkdf2 = new Rfc2898DeriveBytes("", new byte[] { }, 4000))
            {
                var key = pbkdf2.GetBytes(64);
            }

            // CTSECISSUE:InsecurePBEWorkFactor
            using (var pbkdf3 = new Rfc2898DeriveBytes("", 15, 5000))
            {
                var key = pbkdf3.GetBytes(64);
            }

            // CTSECISSUE:InsecurePBEWorkFactor
            using (var pbkdf3 = new Rfc2898DeriveBytes(new byte[] { }, new byte[] { }, 5000))
            {
                var key = pbkdf3.GetBytes(64);
            }
        }
    }
}
