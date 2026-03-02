using System.Text.RegularExpressions;

namespace ValidateTimeFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time:");
            string input = Console.ReadLine();

            string pattern = @"^(0[1-9]|1[0-2]):[0-5][0-9]\s?(am|pm)$";

            if (Regex.IsMatch(input.ToLower(), pattern)){
                Console.WriteLine("Valid");
            } else Console.WriteLine("Invalid");
        }
    }
}
