using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class Program
    {


        //When you create a public forum, you have the problem of inappropriate language being used in messages. Many forum system replace profanity with more appropriate language automatically.

        //Create a new class named ProfanityCleaner that exposes a method named Clean() that cleans a string of profanity by performing the following replacements:
        //•darn =>  d**n
        //•gosh => g**h
        //•yuck => y**k

        //Use Debug.Assert() to verify that the Clean() method works correctly.

        //Extra Credit: Ensure that the replacement is not case-sensitive.

        static void Main(string[] args)
        {
            var cc = new ProfanityCleaner();

            // This looks for specific words not just the string within.
            //this should  replace yuck
            var s = cc.Clean("this is yuck a a sds");
            Console.WriteLine(s);

            // This looks for specific words not just the string within.
            //this should not replace yucky
             s = cc.Clean("this is yucky a a sds");
            Console.WriteLine(s);



            // This should not replace
            s = cc.Clean("this is a darning needle ");
            Console.WriteLine(s);

            // This looks for specific words if Case is different
            s = cc.Clean("this is YUCK a a sds");
            Console.WriteLine(s);


            Console.ReadLine();
        }
    }

    class ProfanityCleaner
    {
        System.Collections.Generic.Dictionary<string, string> lookupList;

        public ProfanityCleaner()
        {
            lookupList = new System.Collections.Generic.Dictionary<string, string>();
            lookupList.Add("darn", "d**n");
            lookupList.Add("gosh", "g**h");
            lookupList.Add("yuck", "y**k");


        

        }
        public string Clean(string s)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            var words = s.Split((new char[]{' '}) );

            //Break into words
            foreach (var word in words)
            {
                sb.Append(LookupWord(word));
            }
            //For each word - determine if it was a word in the lookup
            //  Add to new string if it wasn't
            // Replace with alternative if it was.
            return sb.ToString();
        }

        private string LookupWord(string s)
        {
            string retString = null;

            if (lookupList.ContainsKey(s.ToLower ()))
            {
                retString = lookupList[s.ToLower()];
                
            }
            else
            {
                retString = s;
            }
            return retString + " ";
        }
    }
}
