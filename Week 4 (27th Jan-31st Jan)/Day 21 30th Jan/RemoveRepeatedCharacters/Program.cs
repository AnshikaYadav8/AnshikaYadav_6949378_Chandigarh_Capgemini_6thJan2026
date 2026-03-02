using System.Text.RegularExpressions;

namespace RemoveRepeatedCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input:");
            string input = Console.ReadLine();
            string pattern = @"(?![ ])(.)(?<=\1.*\1)";
            string result = Regex.Replace(input, pattern, "", RegexOptions.Singleline);
            Console.WriteLine("Result: "+result);
        }
    }
}
