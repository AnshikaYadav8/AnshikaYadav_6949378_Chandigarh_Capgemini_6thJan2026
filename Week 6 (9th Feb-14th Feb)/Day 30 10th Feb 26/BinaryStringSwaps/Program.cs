namespace BinaryStringSwaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary string:");
            string s = Console.ReadLine();
            int count00 = 0;
            int count01 = 0;
            for (int i = 0; i < s.Length; i += 2)
            {
                string pair = s.Substring(i, 2);
                if (pair == "00") count00++;
                else if (pair == "01") count01++;
            }
            int longest = (count00 + count01) * 2;
            Console.WriteLine("Result: "+longest);
        }
    }
}
