
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NETStandaloneBlot.Other
{
    class DangerousRegularExpression1
    {
        public void Run()
        {
            // CTSECISSUE:UseofDangerousRegularExpressions
            Regex.IsMatch(System.Console.ReadLine(), "(a+)+k");

            // CTSECISSUE:UseofDangerousRegularExpressions
            Regex.IsMatch(System.Console.ReadLine(), "(a+)+k", RegexOptions.Compiled);

            // gives timespan so, NO ISSUE HERE!
            // CTNONSECISSUE:UseofDangerousRegularExpressions
            Regex.IsMatch(System.Console.ReadLine(), "(a+)+k", RegexOptions.Compiled, TimeSpan.FromSeconds(10));

            // CTSECISSUE:UseofDangerousRegularExpressions
            Regex.Replace(System.Console.ReadLine(), "(a+)+k", "");
            
            // CTSECISSUE:UseofDangerousRegularExpressions
            Regex.Replace(System.Console.ReadLine(), "(a+)+k", "", RegexOptions.Compiled);
            
            // gives timespan so, NO ISSUE HERE!
            // CTNONSECISSUE:UseofDangerousRegularExpressions
            Regex.Replace(System.Console.ReadLine(), "(a+)+k", "", RegexOptions.Compiled, TimeSpan.FromSeconds(10));

            // CTSECISSUE:UseofDangerousRegularExpressions
            Regex.Match(System.Console.ReadLine(), "(a+)+k");

            // CTSECISSUE:UseofDangerousRegularExpressions
            Regex.Match(System.Console.ReadLine(), "(a+)+k", RegexOptions.Compiled);

            // gives timespan so, NO ISSUE HERE!
            // CTNONSECISSUE:UseofDangerousRegularExpressions
            Regex.Match(System.Console.ReadLine(), "(a+)+k", RegexOptions.Compiled, TimeSpan.FromSeconds(10));
        }
    }
}
