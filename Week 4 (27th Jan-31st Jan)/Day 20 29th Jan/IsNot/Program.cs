namespace IsNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Negative String: " + UserProgramCode.negativeString(input));
        }
    }
}
