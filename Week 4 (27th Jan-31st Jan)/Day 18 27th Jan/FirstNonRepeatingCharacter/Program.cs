namespace FirstNonRepeatingCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach(char c in arr)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                } else
                {
                    map[c] = 1;
                }
            }
            foreach(var s in map)
            {
                if(s.Value == 1)
                {
                    Console.WriteLine(s.Key);
                    break;
                }
            }
        }
    }
}
