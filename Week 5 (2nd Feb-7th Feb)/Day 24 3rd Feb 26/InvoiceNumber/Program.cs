using System.Text.RegularExpressions;

namespace InvoiceNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Invoice Number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Increment Value");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int code = 0;
            foreach(Match m in Regex.Matches(input1, @"\d+"))
            {
                code = Convert.ToInt32(m.Value);
            }
            code = code + input2;
            input1 = Regex.Replace(input1, @"\d+", code.ToString());
            Console.WriteLine("Updated Invoice: " + input1);
        }
    }
}
