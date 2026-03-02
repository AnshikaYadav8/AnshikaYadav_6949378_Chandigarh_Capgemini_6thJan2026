using System;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, output, sum=0;
            Console.WriteLine("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            if(input < 0)
            {
                output = -2;
                Console.WriteLine(output);
            }
            else
            {
                for(int i=1; i<=input/2; i++)
                {
                    if (input % i == 0)
                    {
                        sum += i;
                    }
                }
                if(sum == input)
                {
                    output = 1;
                    Console.WriteLine(output);
                } else
                {
                    output = -1;
                    Console.WriteLine(output);
                }
            }
        }
    }
}
