using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace UniversityEnrollmentSystem
{
    internal class Person
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public virtual void Details()
        {
            Console.WriteLine("Enter Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Phone no: ");
            this.PhoneNo = Console.ReadLine();
        }
        public virtual void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Phone no: " + PhoneNo);
        } 
    }
}
