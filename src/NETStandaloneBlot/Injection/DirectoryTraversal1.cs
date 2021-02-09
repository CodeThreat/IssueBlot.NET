
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NETStandaloneBlot.Injection
{
    class DirectoryTraversal1
    {
        public void Run()
        {
            String filename = System.Console.ReadLine();
            if (File.Exists(@"D:\wwwroot\reports\" + filename))
            {
                // CTSECISSUE:DirectoryTraversal
                File.Delete(@"D:\wwwroot\reports\" + filename);
            }

            //CTSECISSUE:DirectoryTraversal
            byte[] content1 = File.ReadAllBytes(System.Console.ReadLine());
            
            //CTSECISSUE:DirectoryTraversal
            string content2 =File.ReadAllText(System.Console.ReadLine());

            //CTSECISSUE:DirectoryTraversal
            var fileStream = File.OpenRead(System.Console.ReadLine());

            //CTSECISSUE:DirectoryTraversal
            var streamReader = File.OpenText(System.Console.ReadLine());

            //CTSECISSUE:DirectoryTraversal
            var content3 = File.ReadAllLines(System.Console.ReadLine());

            //CTSECISSUE:DirectoryTraversal
            var content4 = File.ReadLines(System.Console.ReadLine());
        }
    }
}
