namespace InsertMultipleStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();

            Console.Write("How many substrings you want to add:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Substring: ");
                string sub = Console.ReadLine();

                Console.Write("Position: ");
                int pos = int.Parse(Console.ReadLine());

                s = s.Insert(pos, sub);
            }
            Console.WriteLine(s);
        }
    }
}
