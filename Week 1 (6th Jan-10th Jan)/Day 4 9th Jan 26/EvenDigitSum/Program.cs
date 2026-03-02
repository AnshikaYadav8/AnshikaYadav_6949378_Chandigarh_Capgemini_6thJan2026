namespace EvenDigitSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int output = 0;
            if (num < 0)
                output = -1;
            else if (num > 32767)
                output = -2;
            else
            {
                while (num > 0)
                {
                    int d = num % 10;
                    if (d % 2 == 0)
                        output += d;
                    num /= 10;
                }
            }
            Console.WriteLine("Sum: "+output);
        }
    }
}
