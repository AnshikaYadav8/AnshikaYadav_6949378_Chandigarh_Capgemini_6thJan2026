namespace ConsoleAppCU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter value of x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y");
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (y > x)
            {
                Console.WriteLine("y is greater than x");
            }
            else
            {
                Console.WriteLine("Both x and y are equal");
            }
        }
    }
}
