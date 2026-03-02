namespace RomanToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Roman Number: ");
            string input = Console.ReadLine();
            int output = UserProgramCode.romanToDecimal(input);
            Console.WriteLine("Decimal Number: " + output);
        }
    }
}
