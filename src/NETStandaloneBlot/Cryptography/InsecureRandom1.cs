using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class InsecureRandom1
    {
        public void Run()
        {
            var chars = "ABCDEFGHIJKLMNOPQRYZabcdefghijklmwxyz0123456789";
            var output = new char[8];
            // CTSECISSUE:InsecureRandomNumberGenerator
            var random = new Random();
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = chars[random.Next(chars.Length)];
            }
        }
    }
}
