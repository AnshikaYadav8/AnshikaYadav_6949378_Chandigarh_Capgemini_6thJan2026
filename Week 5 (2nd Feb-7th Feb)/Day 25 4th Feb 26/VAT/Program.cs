using System.Text.RegularExpressions;

namespace VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter:");
            char product = Convert.ToChar(Console.ReadLine());
            double vat = 0;

            string input = product.ToString();

            if (Regex.IsMatch(input, "M"))
                vat = 5;
            else if (Regex.IsMatch(input, "V"))
                vat = 12;
            else if (Regex.IsMatch(input, "C"))
                vat = 6.25;
            else if (Regex.IsMatch(input, "D"))
                vat = 6;

            Console.WriteLine("VAT = " + vat + "%");
        }
    }
}
