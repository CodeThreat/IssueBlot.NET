using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class LackOfEqualsImplementation
    {
        public void Run()
        {
            var object1 = new CustomClassWithoutEquals("bob", 34);
            var object2 = new CustomClassWithoutEquals("bob", 34);
            
            // CTSECISSUE:LackofEqualsImplementation
            if (object1.Equals(object2))
            {

            }

            var object3 = new CustomClassWithEquals("bob", 34);
            var object4 = new CustomClassWithEquals("bob", 34);

            // CTNONSECISSUE:LackofEqualsImplementation
            if (object3.Equals(object4))
            {

            }
        }
    }

    class CustomClassWithoutEquals
    {
        public CustomClassWithoutEquals(string name, int age)
        {

        }
    }

    class CustomClassWithEquals
    {
        public CustomClassWithEquals(string name, int age)
        {

        }

        public override bool Equals(System.Object obj)
        {
            return true;
        }
    }
}
