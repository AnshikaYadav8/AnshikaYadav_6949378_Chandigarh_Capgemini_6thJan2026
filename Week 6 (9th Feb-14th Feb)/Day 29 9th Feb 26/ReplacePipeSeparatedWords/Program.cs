namespace ReplacePipeSeparatedWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter pipe separated words:");
            var arr = Console.ReadLine().Split('|');
            Array.Reverse(arr);
            Console.WriteLine(String.Join("|", arr));
        }
    }
}
