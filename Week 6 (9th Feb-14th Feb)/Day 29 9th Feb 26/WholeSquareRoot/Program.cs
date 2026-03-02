namespace WholeSquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            double root = Math.Sqrt(num);
            if (root == Math.Floor(root))
            {
                Console.WriteLine(num + " has a whole square root");
                return;
            }
            double floor = Math.Floor(root);
            double ceiling = Math.Ceiling(root);
            floor = floor * floor;
            ceiling = ceiling * ceiling;
            int close = 0;
            if (Math.Abs(num - floor) < Math.Abs(num - ceiling)) close = (int)floor;
            else close = (int)ceiling;
            Console.WriteLine("Closest number with whole square root: " + close);
        }
    }
}
