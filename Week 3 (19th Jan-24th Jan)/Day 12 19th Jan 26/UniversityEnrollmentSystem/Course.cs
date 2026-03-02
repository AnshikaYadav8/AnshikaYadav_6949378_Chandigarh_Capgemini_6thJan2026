using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    internal class Course
    {
        List<string> CourseList = new List<string>()
        {
            "DBMS",
            "OS",
            "DSA"
        };
        public void CourseDisplay()
        {
            Console.WriteLine("Following courses are assigned: ");
            foreach (string course in CourseList)
            {
                Console.WriteLine(course);
            }
        }
    }
}
