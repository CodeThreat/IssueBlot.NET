using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class PossibleDivideByZero
    {
        public void Run()
        {
            int[] m = { 1, 2, 3, 4, 5, 6 };
            int[] n = { 1, 2, 3, 4, 5, 6 };

            int x, y = 0, z = 0;

            y = Convert.ToInt32(System.Console.ReadLine());
            x = Convert.ToInt32(System.Console.ReadLine());
            // CTSECISSUE:IntegerOverflow
            z = x * y * x;
            // CTSECISSUE:PossibleDivideByZero
            x = y / z;
            if (z == 0)
            {

            }
            else
            {
                // CTNSECNONISSUE:PossibleDivideByZero
                x = y / z;
            }
            // CTNSECISSUE:IncorrectCalltoEqualswithArray
            if (m.Equals(n))
            {

            }
            // CTNSECISSUE:IncorrectCalltoEqualswithArray
            if (m == n)
            {

            }
            // CTNSECNONISSUE:IncorrectCalltoEqualswithArray
            if (m.SequenceEqual(n))
            {

            }

        }
    }
}
