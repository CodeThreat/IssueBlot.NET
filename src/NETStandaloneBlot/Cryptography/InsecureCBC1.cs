
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class InsecureCBC1
    {
        public void Run()
        {
            // CTSECISSUE:InsecureSymmetricEncryptionMode-CBC
            RijndaelManaged rm = new RijndaelManaged();

            // CTSECISSUE:InsecureSymmetricEncryptionMode-CB
            RijndaelManaged rm2 = new RijndaelManaged();
            rm2.Mode = CipherMode.CBC;

            // CTSECISSUE:InsecureSymmetricEncryptionMode-CBC
            RijndaelManaged rm3 = new RijndaelManaged
            {

            };
        }
    }
}
