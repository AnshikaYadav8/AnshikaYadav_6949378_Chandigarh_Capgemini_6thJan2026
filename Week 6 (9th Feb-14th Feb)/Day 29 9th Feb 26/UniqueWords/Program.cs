namespace UniqueWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words:");
            var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var map = new Dictionary<string, int>();

            foreach (var w in words)
            {
                var key = String.Concat(w.OrderBy(c => c));
                map[key] = map.ContainsKey(key) ? map[key] + 1 : 1;
            }

            var result = words.Where(w => map[String.Concat(w.OrderBy(c => c))] == 1);
            Console.WriteLine("Unique words:");
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
