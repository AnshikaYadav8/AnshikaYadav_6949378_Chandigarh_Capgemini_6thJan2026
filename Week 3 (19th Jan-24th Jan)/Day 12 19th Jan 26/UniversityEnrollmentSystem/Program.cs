namespace UniversityEnrollmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Student 2. Professor 3. Staff");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Student obj1 = new Student();
                    obj1.Details();
                    obj1.Display();
                    obj1.PrintSchedule();
                    break;
                case 2:
                    Professor obj2 = new Professor();
                    obj2.Details();
                    obj2.Display();
                    Course course = new Course();
                    course.CourseDisplay();
                    obj2.PrintSchedule();
                    break;
                case 3:
                    Staff obj3 = new Staff();
                    obj3.Details();
                    obj3.Display();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
