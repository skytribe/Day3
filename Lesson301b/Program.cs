using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson301b
{
    class Product
    {
        public string Name { get; set; }
    }


    class Program
    {
        static void DoSomething(Product value)
        {
            value.Name = "Cheese";
        }

        static void Main(string[] args)
        {
            var product1 = new Product
            {
                Name = "Eggs"
            };
            DoSomething(product1);
            Console.WriteLine("The value of product1.Name is " + product1.Name);

            // pause
            Console.ReadLine();
        }
    }

}
