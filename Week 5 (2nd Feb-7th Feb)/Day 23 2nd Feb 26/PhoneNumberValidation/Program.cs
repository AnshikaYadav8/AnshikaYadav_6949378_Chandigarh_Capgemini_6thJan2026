using System.Text.RegularExpressions;

namespace PhoneNumberValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();
            foreach(Match m in Regex.Matches(input, @"[\d]{10}"))
            {
                Console.WriteLine(m);
            }
        }
    }
}
