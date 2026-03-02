namespace CountVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            int count = 0;
            foreach(char c in input)
            {
                char s = char.ToLower(c);
                if(s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
