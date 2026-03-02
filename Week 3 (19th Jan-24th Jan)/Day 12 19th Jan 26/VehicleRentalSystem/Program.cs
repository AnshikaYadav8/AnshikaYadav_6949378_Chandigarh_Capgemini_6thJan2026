namespace VehicleRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Details");
            Customer customer = new Customer();
            customer.Display();
            Console.WriteLine("1.Car 2.Truck 3.Bike");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Car obj1 = new Car();
                    obj1.AddVehicle();
                    RentalTransaction r1 = new RentalTransaction();
                    r1.Vehicle = obj1;
                    Console.WriteLine("Enter total no of days: ");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Rate: "+r1.CalculateCharges(input2));
                    break;
                case 2:
                    Truck obj2 = new Truck();
                    obj2.AddVehicle();
                    RentalTransaction r2 = new RentalTransaction();
                    r2.Vehicle = obj2;
                    Console.WriteLine("Enter total no of days: ");
                    int input3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Rate: "+r2.CalculateCharges(input3));
                    break;
                case 3:
                    Bike obj3 = new Bike();
                    obj3.AddVehicle();
                    RentalTransaction r3 = new RentalTransaction();
                    r3.Vehicle = obj3;
                    Console.WriteLine("Enter total no of days: ");
                    int input4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Rate: "+r3.CalculateCharges(input4));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
