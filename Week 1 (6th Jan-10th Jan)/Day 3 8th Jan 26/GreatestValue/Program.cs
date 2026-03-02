namespace GreatestValue
{
    internal class GreatestValue
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter value 1: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 2: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 3: ");
            z = int.Parse(Console.ReadLine());
            if (x > y && x > z)
            {
                Console.WriteLine(x + " is the greatest no");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine(y + " is the greatest no");
            }
            else
            {
                Console.WriteLine(z + " is the greatest no");
            }
        }
    }
}
