using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    public class DemoClassFromClassLibrary
    {
        public int WordCounter(string s)
        {
            int retVal = 0;
            retVal = s.Split().Length;

            return retVal;
        }
    }
}
