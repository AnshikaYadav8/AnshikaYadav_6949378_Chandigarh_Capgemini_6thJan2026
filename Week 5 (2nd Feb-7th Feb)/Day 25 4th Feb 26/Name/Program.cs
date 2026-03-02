using System.Text.RegularExpressions;

namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            string pattern = @"^.{16,}$";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Name is more than 15 characters");
            }
            else
            {
                Console.WriteLine("Hi how are you Dear " + name);
            }
        }
    }
}
