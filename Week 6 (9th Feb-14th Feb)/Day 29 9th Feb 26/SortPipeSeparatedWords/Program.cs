namespace SortPipeSeparatedWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split('|');
            Array.Sort(arr);
            Console.WriteLine(String.Join("|", arr));
        }
    }
}
