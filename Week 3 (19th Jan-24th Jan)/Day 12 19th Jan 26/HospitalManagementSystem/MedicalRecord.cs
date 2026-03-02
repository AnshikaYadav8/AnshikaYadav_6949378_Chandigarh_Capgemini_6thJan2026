using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    internal class MedicalRecord
    {
        public string History;
        public void AddRecord()
        {
            Console.WriteLine("Enter Medical History:");
            History = Console.ReadLine();
        }
        public void DisplayHistory()
        {
            Console.WriteLine("History: " + History);
        }
    }
}
