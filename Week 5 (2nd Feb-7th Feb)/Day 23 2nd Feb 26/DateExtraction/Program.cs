using System.Text.RegularExpressions;

namespace DateExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();
            foreach(Match m in Regex.Matches(input, @"[\d]{2}/[\d]{2}/[\d]{4}"))
            {
                Console.WriteLine(m);
            }
        }
    }
}
