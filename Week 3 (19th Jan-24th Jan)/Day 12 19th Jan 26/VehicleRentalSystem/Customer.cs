using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Customer
    {
        static int CustomerID = 100;
        public string Name { get; set; }

        public Customer()
        {
            Console.WriteLine("Enter Name: ");
            this.Name = Console.ReadLine();
            CustomerID++;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Customer Id: " + CustomerID);
        }
    }
}
