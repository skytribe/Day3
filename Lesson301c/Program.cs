using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson301c
{
    class Program
    {
        static void DoSomething(string value)
        {
            value = "Goodbye!";
        }

        static void Main(string[] args)
        {
            var message1 = "Hello!";
            DoSomething(message1);
            Console.WriteLine("The value of message1 is " + message1);

            // pause
            Console.ReadLine();
        }
    }

}
