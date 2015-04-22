using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartArrayList
{
    class Program
    {
//        Create a ShoppingCart class and a ShoppingCartItem class. The ShoppingCartItem class represents a particular item in your shopping cart and has the following three properties:
//•Id - An integer representing the unique id of the item.
//•Name - The name of the item.
//•Price - The price of the item.

//The ShoppingCart class should support the following methods:
//•AddItem() - Enables you to add a new item to the shopping cart and returns the Id of the new item. For example, AddItem("Beanie Baby", 12.34m).
//•RemoveItem() - Enables you to remove an item from the shopping cart. For example, RemoveItem(2).
//•ListItems() - Enables you to list all of the items in the shopping cart.

//Use Debug.Assert() to verify that each of these three methods work in the way that you expect.

        static void Main(string[] args)
        {
            var sl = new ShopingCart ();
            sl.AddItem("sss", 10m);
            sl.ListItems();
            sl.RemoveItem(0);
            sl.RemoveItem(0);
        }
    }

    class ShopingCart
    {
        System.Collections.ArrayList l = new System.Collections.ArrayList();

        public void AddItem(string name, decimal price)
        {
            int id = l.Count + 1;

            var newItem = new ShoppingCartItem(id, name, price);

            l.Add(newItem );
        }
        public void RemoveItem(int index)
        {
            if (index < l.Count && l.Count != 0  )
            {
                l.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Index is Out of Range");
            }
        }

        public void ListItems()
        {
            foreach (var item in l)
            {
                Console.WriteLine("{0}", item.ToString());
            }
        }
    }
    
    class ShoppingCartItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ShoppingCartItem(int id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
          
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}    :{2}",ID,Name,Price);
        }
    }
}
