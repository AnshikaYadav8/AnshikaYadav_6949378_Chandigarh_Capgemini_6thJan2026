using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    internal class Professor : Person
    {
        static int ProfessorId = 1000;
        public string Department { get; set; }
        override public void Details()
        {
            Console.WriteLine("Enter Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            this.Department = Console.ReadLine();
            Console.WriteLine("Enter Phone no: ");
            this.PhoneNo = Console.ReadLine();
            ProfessorId++;
        }
        public override void Display()
        {
            Console.WriteLine("Professor Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Professor Id: " + ProfessorId);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Phone no: " + PhoneNo);
        }
        public void PrintSchedule()
        {
            Console.WriteLine("-----------Schedule----------");
            Console.WriteLine("10:30-11:30 - DBMS");
            Console.WriteLine("11:30-12:30 - OS");
            Console.WriteLine("12:30-01:30 - DSA");
        }
    }
}
