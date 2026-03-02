namespace PositionOfTheAndOff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of lines: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter strings:");
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine("Index of 'The': "+s.IndexOf("the"));
                Console.WriteLine("Index of 'OF': "+s.IndexOf("of"));
            }
        }
    }
}
