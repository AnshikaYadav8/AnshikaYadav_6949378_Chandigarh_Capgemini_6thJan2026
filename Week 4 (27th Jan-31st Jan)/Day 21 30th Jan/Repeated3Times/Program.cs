using System.Text.RegularExpressions;

namespace Repeated3Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"(.)\1{2}");
            Console.WriteLine("Character repeated 3 times consecutively: "+matches.Count);
        }
    }
}
