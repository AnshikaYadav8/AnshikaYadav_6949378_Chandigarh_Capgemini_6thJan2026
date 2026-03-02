namespace LongestSubstringWithoutRepetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Dictionary<char, int> last = new Dictionary<char, int>();
            int left = 0, maxlen = 0;
            for(int right = 0; right < input.Length; right++)
            {
                if (last.ContainsKey(input[right]))
                {
                    left = Math.Max(left, last[input[right]]+1);
                }
                last[input[right]] = right;
                maxlen = Math.Max(maxlen, right - left + 1);
            }
            Console.WriteLine(maxlen);
        }
    }
}
