namespace ReplaceFirstOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();

            Console.Write("Character to replace: ");
            char a = Console.ReadLine()[0];

            Console.Write("Replace with: ");
            char b = Console.ReadLine()[0];

            int i = s.IndexOf(a);
            if (i >= 0)
            {
                char[] arr = s.ToCharArray();
                arr[i] = b;
                s = new string(arr);
            }

            Console.WriteLine(s);
        }
    }
}
