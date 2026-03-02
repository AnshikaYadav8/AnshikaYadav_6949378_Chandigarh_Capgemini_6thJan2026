namespace ScoreByPalindrome
{
    internal class Program
    {
        static bool IsPal(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - 1 - i]) return false;
            return true;
        }

        static void Main()
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();
            int score = 0;

            for (int i = 0; i + 3 < s.Length; i++)
                if (IsPal(s.Substring(i, 4))) score += 5;

            for (int i = 0; i + 4 < s.Length; i++)
                if (IsPal(s.Substring(i, 5))) score += 10;

            Console.WriteLine(score);
        }
    }
}
