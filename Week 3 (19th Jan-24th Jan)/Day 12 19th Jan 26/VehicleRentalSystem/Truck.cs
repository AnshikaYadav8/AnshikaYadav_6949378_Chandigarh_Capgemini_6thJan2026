using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Truck: Vehicle
    {
        static int TruckId = 1;
        public override void AddVehicle()
        {
            Console.WriteLine("Enter Model Name: ");
            this.Model = Console.ReadLine();
            Console.WriteLine("Enter Rental Rate");
            this.RentalRate = Convert.ToInt32(Console.ReadLine());
            TruckId++;
        }
    }
}
