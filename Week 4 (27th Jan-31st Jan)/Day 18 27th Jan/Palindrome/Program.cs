namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            bool p = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        p = true;
                    }
                }
            }
            if (p)
            {
                Console.WriteLine("The string is a palindrome");
            } else
            {
                Console.WriteLine("The string is not a palindrome");
            }
        }
    }
}
