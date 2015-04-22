using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new DemoClassLibrary.DemoClassFromClassLibrary();
            var y1 = x.WordCounter("ssss ssss sss");
            Console.WriteLine("{0}", y1);
         

            var y1a = new TestProperties();
       

            //Extension Methods

            var dc = new Derived();
            var x2 = dc.MethodExtension();
            var x3 = x2.ToString().Shout();

            var shout1 = "tttt".Shout();
            var shout2 = extension.Shout("ttttt");

            Console.WriteLine(x3);
            Console.ReadLine();
        }

    }

    class TestProperties
    {


        public int MyProperty { get; set; }

        private int myVar;

        public int MyProperty2
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
    }

     class Base
    {

    }

    class Derived : Base
    {

    }

   static class extension
    {
        static public int MethodExtension(this Derived a) {
            return 1;
    }
        static public string Shout(this string a)
        {
            return a + "!";
        }
    }
}
