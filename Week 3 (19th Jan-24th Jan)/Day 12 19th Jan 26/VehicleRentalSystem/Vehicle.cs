using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Vehicle
    {
        public string Model { get; set; }
        public double RentalRate { get; set; }
        public virtual void AddVehicle()
        {
            Console.WriteLine("Enter Model Name: ");
            this.Model = Console.ReadLine();
            Console.WriteLine("Enter Rental Rate");
            this.RentalRate = Convert.ToInt32(Console.ReadLine());
        }
    }
}
