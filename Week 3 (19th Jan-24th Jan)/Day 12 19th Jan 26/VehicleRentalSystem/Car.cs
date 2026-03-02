using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Car: Vehicle
    {
        static int CarId = 1;
        public override void AddVehicle()
        {
            Console.WriteLine("Enter Model Name: ");
            this.Model = Console.ReadLine();
            Console.WriteLine("Enter Rental Rate");
            this.RentalRate = Convert.ToInt32(Console.ReadLine());
            CarId++;
        }
    }
}
