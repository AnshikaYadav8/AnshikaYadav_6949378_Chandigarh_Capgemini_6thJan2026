using System.Text.RegularExpressions;
using System.Text.RegularExpressions;

namespace EmployeeDesignation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of employees: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (Regex.IsMatch(input1.ToString(), @"[^0-9]"))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            Console.WriteLine("Enter the employee details: ");
            int size = input1 * 2;
            string[] input2 = new string[size];
            for(int i=0; i<size; i++)
            {
                input2[i] = Console.ReadLine();
            }
            for (int i = 0; i < input1; i++)
            {
                if (Regex.IsMatch(input2[i], @"[^a-zA-Z]"))
                {
                    Console.WriteLine("Invalid Input");
                    return;
                }
            }
            Console.WriteLine("Enter designation: ");
            string input3 = Console.ReadLine();
            Console.WriteLine("Employee name: " + string.Join(" ",UserProgramCode.getEmployee(input2, input3)));
        }
    }
}
