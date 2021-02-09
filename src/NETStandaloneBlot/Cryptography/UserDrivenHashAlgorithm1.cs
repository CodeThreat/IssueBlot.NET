
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class UserDrivenHashAlgorithm1
    {
        public void Run()
        {
            string selectedHashAlgorithm = System.Console.ReadLine();
            // CTSECISSUE:UserDrivenInsecureHashAlgorithm
            var hashAlgorithm = HashAlgorithm.Create(selectedHashAlgorithm);
        }
    }
}
