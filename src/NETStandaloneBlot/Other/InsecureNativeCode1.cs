
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class InsecureNativeCode1
    {
        // DllImport data annotation is the flag here... NOT the name Transact!

        // CTSECISSUE:InsecureNativeCodeInteraction
        [DllImport("Legacy.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Transact([MarshalAs(UnmanagedType.LPStr)]string path);

        static void Main(string[] args)
        {            
            bool ret = Transact(System.Console.ReadLine());
        }

    }
}
