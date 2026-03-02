using System.Text.RegularExpressions;

namespace ReplaceString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input1 = Console.ReadLine();
            if(Regex.IsMatch(input1, @"[^a-zA-Z0-9 ,]"))
            {
                Console.WriteLine("Invalid string");
                return;
            }
            Console.WriteLine("Enter which word you want to replace: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                Console.WriteLine("Not positive number");
                return;
            }
            Console.WriteLine("Enter the special character: ");
            char input3 = Convert.ToChar(Console.ReadLine());
            if (Char.IsLetter(input3) || Char.IsDigit(input3))
            {
                Console.WriteLine("Not special character");
            }
            Console.WriteLine("Replaced string: " + UserProgramCode.replaceString(input1, input2, input3));
        }
    }
}
