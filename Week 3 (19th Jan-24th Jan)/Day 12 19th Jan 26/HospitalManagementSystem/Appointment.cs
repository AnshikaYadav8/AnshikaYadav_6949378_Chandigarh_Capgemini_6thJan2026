using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    internal class Appointment
    {
        public Doctor Doctor;
        public string Date;
        public void Schedule()
        {
            Console.WriteLine("Enter Appointment Date:");
            Date = Console.ReadLine();

            Console.WriteLine("Appointment Scheduled");
        }
    }
}
