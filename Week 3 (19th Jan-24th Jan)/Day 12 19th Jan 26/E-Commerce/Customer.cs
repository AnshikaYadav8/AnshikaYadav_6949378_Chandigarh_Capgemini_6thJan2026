using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Customer
    {
        public string Name;
        static int CustomerId = 100;

        public Customer()
        {
            Console.WriteLine("Enter Customer Name:");
            Name = Console.ReadLine();
            CustomerId++;
        }
        public void Display()
        {
            Console.WriteLine("Customer Name: " + Name);
            Console.WriteLine("Customer Id: " + CustomerId);
        }
    }
}
