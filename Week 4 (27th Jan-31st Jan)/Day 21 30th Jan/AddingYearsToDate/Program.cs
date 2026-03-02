using System.Globalization;
using System.Text.RegularExpressions;

namespace AddingYearsToDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date (dd/MM/yyyy): ");
            string dateInput = Console.ReadLine();

            Console.Write("Enter how many years you want to add: ");
            string yearInput = Console.ReadLine();

            if (!Regex.IsMatch(dateInput, @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$"))
            {
                Console.WriteLine("-1");
                return;
            }

            if (!Regex.IsMatch(yearInput, @"^-?\d+$"))
            {
                Console.WriteLine("-2");
                return;
            }

            int years = int.Parse(yearInput);
            if (years < 0)
            {
                Console.WriteLine("-2");
                return;
            }

            DateTime date = DateTime.ParseExact(
                dateInput,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );
            Console.WriteLine("Date: "+date.AddYears(years).ToString("dd/MM/yyyy"));
        }
    }
}
