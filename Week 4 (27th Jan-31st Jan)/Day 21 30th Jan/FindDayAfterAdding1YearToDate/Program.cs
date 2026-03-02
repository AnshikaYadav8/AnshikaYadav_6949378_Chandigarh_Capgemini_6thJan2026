using System.Globalization;
using System.Text.RegularExpressions;

namespace FindDayAfterAdding1YearToDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date:");
            string input = Console.ReadLine();

            if (!Regex.IsMatch(input, @"^\d{2}/\d{2}/\d{4}$"))
            {
                Console.WriteLine("-1");
                return;
            }

            DateTime date = DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Day: "+date.AddYears(1).DayOfWeek);
        }
    }
}
