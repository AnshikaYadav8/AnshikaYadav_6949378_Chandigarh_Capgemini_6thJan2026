using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    internal class Patient: Person
    {
        public int PatientId;
        static int id = 1;
        public override void Register()
        {
            base.Register();
            PatientId = id++;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Patient Id: " + PatientId);
        }
    }
}
