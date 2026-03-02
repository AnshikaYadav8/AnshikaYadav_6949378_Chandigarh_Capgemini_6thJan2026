using System.Text.RegularExpressions;

namespace EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email:");
            string input = Console.ReadLine();
            if(input.Length <= 100 && Regex.IsMatch(input, @"^[a-zA-Z0-9._]+\@[a-zA-Z]+\.[a-z]{2,}$"))
            {
                Console.WriteLine("Valid Email");
            }
            else Console.WriteLine("Invalid Email");
        }
    }
}
