using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalSystem
{
    internal class RentalTransaction
    {
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public double CalculateCharges(int Days)
        {
            return Vehicle.RentalRate*Days;
        }
    }
}
