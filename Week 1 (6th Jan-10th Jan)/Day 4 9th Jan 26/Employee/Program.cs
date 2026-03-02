namespace Employee
{
    internal class Employee
    {
        public int EId, EAge;
        public string EName, ECity;
        public void GetDetails()
        {
            Console.WriteLine("Enter employee id: ");
            this.EId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name: ");
            this.EName = Console.ReadLine();
            Console.WriteLine("Enter employee age: ");
            this.EAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee city: ");
            this.ECity = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Id: " + this.EId);
            Console.WriteLine("Employee Name: " + this.EName);
            Console.WriteLine("Employee Age: " + this.EAge);
            Console.WriteLine("Employee Id: " + this.ECity);
        }
        public class EmployeeDetails()
        {
            static void Main(string[] args)
            {
                Employee obj1 = new Employee();
                Employee obj2 = new Employee();
                Employee obj3 = new Employee();
                obj1.GetDetails();
                obj1.DisplayDetails();
                obj2.GetDetails();
                obj2.DisplayDetails();
                obj3.GetDetails();
                obj3.DisplayDetails();
            }
        }
    }
}

