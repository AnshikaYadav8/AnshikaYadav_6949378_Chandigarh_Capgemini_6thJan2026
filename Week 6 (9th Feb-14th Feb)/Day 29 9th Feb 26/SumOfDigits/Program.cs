namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(num > 0)
            {
                int d = num % 10;
                sum += d;
                num /= 10;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
