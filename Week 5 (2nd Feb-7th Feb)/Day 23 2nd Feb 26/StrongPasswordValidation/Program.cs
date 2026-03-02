using System.Text.RegularExpressions;

namespace StrongPasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password:");
            string input = Console.ReadLine();
            if(Regex.IsMatch(input, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[a-zA-Z0-9@$!%*?&]{8,}$"))
            {
                Console.WriteLine("Strong Password");
            }
            else Console.WriteLine("Weak Password");
        }
    }
}
