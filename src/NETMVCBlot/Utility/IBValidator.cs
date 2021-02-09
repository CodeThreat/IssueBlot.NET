using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace NETMVCBlot.Utility
{
    public class IBValidator
    {
        private static Regex fileNameRegex = new Regex(@"[A-Za-z0-9]+\.[a-z]{3}");
        private static Regex genericInputRegex = new Regex(@"[A-Za-z0-9]+");

        public static bool IsValidFileName(string fileName)
        {
            return fileNameRegex.IsMatch(fileName);
        }

        public static bool IsValidInput(string input)
        {
            return genericInputRegex.IsMatch(input);
        }

    }
}