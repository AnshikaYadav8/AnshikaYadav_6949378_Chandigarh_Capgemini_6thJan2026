using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    internal class Doctor: Person
    {
        public string Specialization;
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Specialization:");
            Specialization = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Specialization: " + Specialization);
        }
    }
}
