using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandaloneBlot.Other
{
    class IncorrectReadonlyMember
    {
        private readonly List<string> iList = new List<string>();

        public void Run()
        {


        }
        public IEnumerable<string> MyList
        {
            get { return iList; }
        }
    }
}
