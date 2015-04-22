using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BetterTryParse
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Create a Visual Studio Console Application named BetterTryParse.

            //The existing int.TryParse() method included in the .NET Framework is not easy to use because it requires you to pass a value by reference.  Taking advantage of nullable types, create a better TryParse() method that satisfies the following conditions:
            //•The better TryParse() method returns the int value when a value can be parsed as an integer.
            //•The better TryParse() method returns null when a value cannot be parsed as an integer.

            //Using Debug.Assert(), verify that your better TryParse() method returns the correct results with the following inputs:
            //•"89898"
            //•"I am not a number"
            //•null
            //•"6.5"

            Nullable<int> x = null;

           
            var x1 = BetterTryParse("4444", ref x);

            x1 = BetterTryParse("Im not a number", ref x);
            x1 = BetterTryParse(null, ref x);
            x1 = BetterTryParse("6.5", ref x);
            x1 = BetterTryParse("ffff", ref x);


             Int32 x2 = 1 ;
            Nullable<Int32> x99 = null;

            var s1 = x2.BetterTryParse2(ref x99, "fddff");
            Debug.Assert(s1== false, "Assert should be false");
            Debug.Assert(x99 == null, "Value should be false");

             s1 = x2.BetterTryParse2(ref x99, "3");
             Debug.Assert(s1 == true, "Assert should be false");
             Debug.Assert(x99 == 3, "Value should be false");

             Console.ReadLine();

        }

        public static bool BetterTryParse(string s, ref Nullable<int> v )
        {
            bool r = false;

            try
            {
                v = int.Parse(s);
                r = true;
            }
            catch (Exception)
            {
                r = false;
                v = null;

            }
            return r;

        }
    }

    public static class extension
    {
        public static bool BetterTryParse2(this  Int32 x, ref Nullable<Int32> v , string s)
        {
            var validvalue = false;
            try
            {
           
                v= int.Parse(s);
          
                validvalue= true;
      
            }
            catch
            {
                validvalue = false;
                v = null;
            }
            return validvalue;
        }

        public static bool BetterTryParse3(this  Int32 x,  string s)
        {
            //var validvalue = false;
            //try
            //{
            //    Nullable<int> x1 = x;

            //    var ret = Program.BetterTryParse(s, ref  x1);
            //    validvalue = ret;
            //}
            //catch
            //{
            //}
            //return validvalue;
            return false;
        }
    }
}