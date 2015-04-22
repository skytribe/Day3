using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = null;

            Console.WriteLine(x.foo());
             x ="222";

            Console.WriteLine(x.foo());
            int? x2 = null;

            Console.WriteLine(x2.foo());

            x2 = 1;

            Console.WriteLine(x2.foo());

            var x3 = new System.Collections.ArrayList();

            Console.WriteLine(x3.foo());
            Console.WriteLine("COMPLETE");
            Console.Read();
        }
    }

    static class extensions {
       public static string foo(this object a)
        {
            if (a == null)
                return "<NULL";
            else
                return a.ToString();
        }
}
}
