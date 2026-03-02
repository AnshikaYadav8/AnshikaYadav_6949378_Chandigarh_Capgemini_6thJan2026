namespace Factorial
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int num, output = 1;
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                output = -1;
            }
            else if (num > 7)
            {
                output = -2;
            }
            else if (num == 0)
            {
                output = 1;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    output *= i;
                }
            }
            Console.WriteLine("Facrorial of " + num + " is: " + output);
        }
    }
}

