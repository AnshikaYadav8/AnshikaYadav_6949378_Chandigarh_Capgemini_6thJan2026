using System.Text.RegularExpressions;

namespace StringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements:");
            int n = int.Parse(Console.ReadLine());
            int flag = 1;
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (!Regex.IsMatch(s, @"^-?\d+(\.\d+)?$"))
                {
                    flag = -1;
                    break;
                }
            }
            Console.WriteLine("Result: "+flag);
        }
    }
}
