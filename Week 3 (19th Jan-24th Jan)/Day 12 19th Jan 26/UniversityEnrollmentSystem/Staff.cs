using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    internal class Staff: Person
    {
        static int EmployeeId = 1;
        public string Role { get; set; }
        override public void Details()
        {
            Console.WriteLine("Enter Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Role: ");
            this.Role = Console.ReadLine();
            Console.WriteLine("Enter Phone no: ");
            this.PhoneNo = Console.ReadLine();
            EmployeeId++;
        }
        public override void Display()
        {
            Console.WriteLine("Staff Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Employee Id: " + EmployeeId);
            Console.WriteLine("Role: " + Role);
            Console.WriteLine("Phone no: " + PhoneNo);
        }
    }
}
