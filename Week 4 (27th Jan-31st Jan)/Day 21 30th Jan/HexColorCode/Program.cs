using System.Text.RegularExpressions;

namespace HexColorCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Hex Color Code:");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^#[0-9A-F]{6}$"))
            {
                Console.WriteLine("Valid Color Code");
            } else
            {
                Console.WriteLine("Invalid Color Code");
            }
        }
    }
}
