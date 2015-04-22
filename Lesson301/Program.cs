using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson301
{
 
        class Program
        {

            static void DoSomething(int value)
            {
                value = 99;
            }

            static void Main(string[] args)
            {
                var number1 = 1;
                DoSomething(number1);
                Console.WriteLine("The value of number1 is " + number1);

                // pause
                Console.ReadLine();
            }
        }
 

}
