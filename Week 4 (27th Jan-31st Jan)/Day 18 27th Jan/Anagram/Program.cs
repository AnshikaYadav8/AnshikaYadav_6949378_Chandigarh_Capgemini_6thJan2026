namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1: ");
            string input1 = Console.ReadLine();
            char[] arr1 = input1.ToCharArray();
            Console.WriteLine("Enter string 2: ");
            string input2 = Console.ReadLine();
            char[] arr2 = input2.ToCharArray();
            int[] freq = new int[26];
            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("Its not an anagram");
                return;
            }
            foreach(char c in arr1)
            {
                freq[c - 'a']++;
            }
            foreach(char c in arr2)
            {
                freq[c - 'a']--;
            }
            foreach (int count in freq)
            {
                if (count != 0)
                {
                    Console.WriteLine("Its not an anagram");
                    return;
                }
            }
            Console.WriteLine("Its an anagram");
        }
    }
}
