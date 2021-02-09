
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NETStandaloneBlot.Cryptography
{
    class InsecureECB1
    {
        public void Run()
        {
            // CTSECISSUE:InsecureSymmetricEncryptionMode-ECB
            AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider
            {
                Mode = CipherMode.ECB
            };

            // CTSECISSUE:InsecureSymmetricEncryptionMode-ECB
            AesCryptoServiceProvider aesCryptoServiceProvider2 = new AesCryptoServiceProvider();
            aesCryptoServiceProvider2.Mode = CipherMode.ECB;

            // CTSECISSUE:InsecureSymmetricEncryptionMode-ECB
            AesManaged aesManaged = new AesManaged
            {
                Mode = CipherMode.ECB
            };

            // CTSECISSUE:InsecureSymmetricEncryptionMode-ECB
            AesManaged aesManaged2 = new AesManaged();
            aesManaged2.Mode = CipherMode.ECB;

            // CTSECISSUE:InsecureSymmetricEncryptionMode-ECB
            RijndaelManaged rm = new RijndaelManaged
            {
                Mode = CipherMode.ECB
            };

            // CTSECISSUE:InsecureSymmetricEncryptionMode-ECB
            RijndaelManaged rm2 = new RijndaelManaged();
            rm2.Mode = CipherMode.ECB;

            // CTSECISSUE:InsecureSymmetricEncryptionMode-ECB
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Mode = CipherMode.ECB;

            // CTSECISSUE:InsecureSymmetricEncryptionMode-ECB
            TripleDESCryptoServiceProvider tdes2 = new TripleDESCryptoServiceProvider
            {
                Mode = CipherMode.ECB
            };


        }
    }
}
