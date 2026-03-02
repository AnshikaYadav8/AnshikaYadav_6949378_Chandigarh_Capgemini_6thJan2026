namespace StringCompression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach(char c in input)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                } else
                {
                    map[c] = 1;
                }
            }
            List<string> output = new List<string>();
            foreach(var v in map)
            {
                output.Add(char.ToString(v.Key));
                output.Add(Convert.ToString(v.Value));
            }
            Console.WriteLine(string.Join("", output));
        }
    }
}
