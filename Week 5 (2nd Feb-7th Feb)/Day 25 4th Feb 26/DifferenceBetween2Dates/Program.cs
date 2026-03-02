namespace DifferenceBetween2Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Date:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd Date:");
            string input2 = Console.ReadLine();
            DateTime d1 = DateTime.ParseExact(input1, "dd/MM/yyyy", null);
            DateTime d2 = DateTime.ParseExact(input2, "dd/MM/yyyy", null);

            int days = (d2 - d1).Days;

            Console.WriteLine("Total Days: "+days + " days");
        }
    }
}
