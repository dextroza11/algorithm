using System;
using System.Collections.Generic;
using System.Text;

namespace SystemTester
{
    class LenStr : Itask
    {
        public string Run(string[] data)
        {
            return data[0].Length.ToString();
        }
    }
}
