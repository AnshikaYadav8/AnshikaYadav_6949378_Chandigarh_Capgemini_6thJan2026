using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Product
    {
        public string Name;
        public string Category;
        public double Price;
        public int Stock = 100;
        public int Quantity;

        public virtual void AddProduct()
        {
            Console.WriteLine("Enter Product Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quantity: ");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }

        public void ViewProduct()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Price: " + Price*Quantity);
        }
    }
}
