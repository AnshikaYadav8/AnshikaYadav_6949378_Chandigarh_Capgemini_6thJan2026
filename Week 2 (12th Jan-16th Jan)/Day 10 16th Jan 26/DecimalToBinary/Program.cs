using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input < 0)
            {
                int res = -1;
                Console.WriteLine(res);
            }
            else
            {
                List<int> output = new List<int>(); 
                while(input > 0)
                {
                    output.Add(input % 2);
                    input /= 2; 
                }
                output.Reverse();
                Console.WriteLine("Number in binary: " + string.Join("", output));
            }
        }
    }
}
