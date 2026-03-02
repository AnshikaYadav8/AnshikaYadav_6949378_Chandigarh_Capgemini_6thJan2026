namespace SumOfSquaresOfOddDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, output;
            Console.WriteLine("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input < 0)
            {
                output = -1;
                Console.WriteLine(output);
            }
            else
            {
                    int sum = 0;
                while (input > 0)
                {
                    int d = input % 10;
                    if (d % 2 != 0)
                    {
                        sum += d * d;
                    }
                    input /= 10;
                }
                output = sum;
                Console.WriteLine("Sum of squares of odd digits: " + output);
            }
        }
    }
}
