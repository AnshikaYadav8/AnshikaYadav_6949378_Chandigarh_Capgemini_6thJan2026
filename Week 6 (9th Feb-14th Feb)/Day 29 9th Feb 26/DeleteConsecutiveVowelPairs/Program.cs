namespace DeleteConsecutiveVowelPairs
{
    internal class Program
    {
        static bool Vowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
        }

        static void Main()
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (Vowel(s[i]) && Vowel(s[i + 1]))
                {
                    count++;
                    i++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
