namespace DeleteAlternatingCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string result = "";
            for(int i=0; i<input.Length; i = i + 2)
            {
                result += input[i];
            }
            Console.WriteLine("New String: " + result);
        }
    }
}
