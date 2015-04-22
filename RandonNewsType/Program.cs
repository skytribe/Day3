using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandonNewsType
{
    class Program
    {
//        Create a new Visual Studio Console Application named RandomNewsWithArrayList.

//Create an ArrayList of 3 news headlines such as "Martians Attack!" and "Seahawks win Superbowl!". Randomly retreive one news headline and display the headline.


        static void Main(string[] args)
        {
            var x = new System.Collections.ArrayList() { "heading 1", "heading 2", "heading 3" };
            var r = new Random();
            while (true)
            {
                var item = r.Next(x.Count);
                var ec = Console.ReadLine();

                Console.WriteLine("Value {0} {1}:", item, x[item]);
                if (ec == "q")
                    break;
            }
        
            

        }
    }
}
