using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueWordsWithHashtable
{
    class Program
    {
//        Create a method named CountUnique() that counts the number of unique words in a string. 
        // For example, if you pass the CountUnique() method the string "The cat and the cat ate the rat" then the method should return the value 5.

//Use Debug.Assert() to verify that the method is working correctly.

        static void Main(string[] args)
        {
            var x1 = CountUnique("the cat sat on the mat with a cat");
            Debug.Assert(x1 == 7, "Invalid count");

             x1 = CountUnique("The cat and the cat ate the rat");
            Debug.Assert(x1 == 5, "Invalid count");

            Console.WriteLine(x1);
        }

        static int CountUnique(string s)
        {
            System.Collections.Hashtable l = new System.Collections.Hashtable();
            int unique = 0;

            var words = s.ToLower ().Split((new char[]{}),StringSplitOptions.RemoveEmptyEntries );
            foreach (var item in words)
            {
                if (!l.ContainsKey(item))
             
                {
                    l.Add(item, 1);
                    unique++;
                }
            }

            return unique;
        }
    }
}
