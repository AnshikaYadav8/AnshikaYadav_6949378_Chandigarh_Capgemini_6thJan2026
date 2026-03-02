using System.Text.RegularExpressions;

namespace MeterReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Reading 1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Reading 2:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter rate per unit:");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int reading1 = 0;
            int reading2 = 0;
            foreach (Match m in Regex.Matches(input1, @"[\d]+"))
            {
                reading1 = Convert.ToInt32(m.Value);
            }
            foreach (Match m in Regex.Matches(input2, @"[\d]+"))
            {
                reading2 = Convert.ToInt32(m.Value);
            }
            int diff = Math.Abs(reading1 - reading2);
            int amount = diff * input3;
            Console.WriteLine("Amount: " + amount);
        }
    }
}
