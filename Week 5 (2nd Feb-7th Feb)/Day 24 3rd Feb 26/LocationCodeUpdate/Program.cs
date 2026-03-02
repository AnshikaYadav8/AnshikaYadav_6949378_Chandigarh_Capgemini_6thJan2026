using System.Text.RegularExpressions;

namespace LocationCodeUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Invoice Number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter New Location Code:");
            string input2 = Console.ReadLine();
            input1 = Regex.Replace(input1, @"-[A-Z]+-", $"-{input2}-");
            Console.WriteLine("New Invoice Number: " + input1);
        }
    }
}
