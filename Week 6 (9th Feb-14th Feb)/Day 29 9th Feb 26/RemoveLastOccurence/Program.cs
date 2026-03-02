namespace RemoveLastOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter word to remove:");
            string w = Console.ReadLine();

            int i = s.LastIndexOf(w);
            if (i >= 0)
                s = s.Remove(i, w.Length);

            Console.WriteLine("Result:");
            Console.WriteLine(s);
        }
    }
}
