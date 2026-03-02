namespace RemoveSubstringAndAddNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();

            Console.Write("Remove substring: ");
            string oldSub = Console.ReadLine();

            Console.Write("Insert new substring: ");
            string newSub = Console.ReadLine();

            int i = s.IndexOf(oldSub);
            if (i >= 0)
            {
                s = s.Remove(i, oldSub.Length);
                s = s.Insert(i, newSub);
            }

            Console.WriteLine(s);
        }
    }
}
