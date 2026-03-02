using System.Text.RegularExpressions;

namespace PresentInInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input 1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Input 2:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter Input 3:");
            string input3 = Console.ReadLine();

            string pattern = Regex.Escape(input2) + @".*" + Regex.Escape(input3);

            if (Regex.IsMatch(input1, pattern)) Console.WriteLine("Result: 1");
            else Console.WriteLine("Result: -1");
        }
    }
}
