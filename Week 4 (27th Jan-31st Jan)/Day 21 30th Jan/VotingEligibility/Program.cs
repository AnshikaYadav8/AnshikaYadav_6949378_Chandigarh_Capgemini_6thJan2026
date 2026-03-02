using System.Text.RegularExpressions;

namespace VotingEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age:");
            string input = Console.ReadLine();

            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                Console.WriteLine("Invalid");
                return;
            }

            int age = int.Parse(input);
            Console.WriteLine(age >= 18 ? "Eligible" : "Not Eligible");
        }
    }
}
