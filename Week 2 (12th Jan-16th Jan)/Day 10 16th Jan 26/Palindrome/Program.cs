namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int output;
            if(input < 0)
            {
                output = -1;
                Console.WriteLine("Output: " + output);
            }
            else
            {
                int original = input;
                int rev = 0, rem = 0;
                while(input != 0)
                {
                    rem = input % 10;
                    rev = rev * 10 + rem;
                    input /= 10;
                }
                if(rev == original)
                {
                    output = 1;
                    Console.WriteLine("Output: " + output);
                }
                else
                {
                    output = -2;
                    Console.WriteLine("Output: " + output);
                }
            }
        }
    }
}
