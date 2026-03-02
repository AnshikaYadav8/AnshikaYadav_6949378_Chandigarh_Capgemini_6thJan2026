namespace PerfectShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            string x = Console.ReadLine();
            Console.Write("y: ");
            string y = Console.ReadLine();
            Console.Write("z: ");
            string z = Console.ReadLine();

            int i = 0, j = 0;
            bool ok = true;

            foreach (char c in z)
            {
                if (i < x.Length && c == x[i]) i++;
                else if (j < y.Length && c == y[j]) j++;
                else { ok = false; break; }
            }

            Console.WriteLine(ok && i == x.Length && j == y.Length ? "Perfect shuffle" : "Not shuffle");
        }
    }
}
