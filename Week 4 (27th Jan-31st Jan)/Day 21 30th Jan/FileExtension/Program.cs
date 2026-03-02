using System.Text.RegularExpressions;

namespace FileExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file name: ");
            string input = Console.ReadLine();

            Match match = Regex.Match(input, @"\.([^.]+)$");

            if (match.Success)
            {
                Console.WriteLine("Result: "+match.Groups[1].Value);
            }
            else Console.WriteLine("-1");
        }
    }
}
