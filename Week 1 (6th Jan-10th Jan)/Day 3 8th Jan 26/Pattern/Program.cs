namespace Pattern
{
    internal class Pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of rows: ");
            int row = int.Parse(Console.ReadLine());
            for (int i = row; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

