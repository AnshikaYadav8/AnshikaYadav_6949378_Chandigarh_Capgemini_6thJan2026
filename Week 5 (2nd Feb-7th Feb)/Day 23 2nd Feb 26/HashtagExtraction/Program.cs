using System.Text.RegularExpressions;

namespace HashtagExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string input = Console.ReadLine();
            foreach(Match m in Regex.Matches(input, @"#[a-zA-Z0-9]+"))
            {
                Console.WriteLine(m);
            }
        }
    }
}
