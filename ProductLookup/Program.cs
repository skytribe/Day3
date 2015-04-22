using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProductLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new ProductCatalog();
            x.Add("a", "product a", 10m);
            x.Add("b", "product b", 20m);
            x.Add("c", "product c", 30m);

            var c = x.Lookup("a");
            Debug.Assert(c != null, "Product returned was null");

            DisplayString(c);

            c = x.Lookup("z");
            Debug.Assert(c == null, "Product returned was null");

            DisplayString(c);
            Console.ReadLine();
        }

        private static void DisplayString(Product c)
        {
            if (c == null)
            {
                Console.WriteLine("Product was not Found");
            }
            else
                Console.WriteLine("{0} was found", c.ID);

        }
    }

    class ProductCatalog
    {
        static Dictionary<string, Product> lis;

        public ProductCatalog()
        {
            lis = new Dictionary<string, Product>();
        }
        public void Add(string i, string n, decimal p)
        {

            lis.Add(i, new Product(i, n, p));
        }

        public Product Lookup(string index)
        {
            Product ret = null;
            if (lis.ContainsKey(index))
                ret = lis[index];

            return ret;

        }

    }

    class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }

}
