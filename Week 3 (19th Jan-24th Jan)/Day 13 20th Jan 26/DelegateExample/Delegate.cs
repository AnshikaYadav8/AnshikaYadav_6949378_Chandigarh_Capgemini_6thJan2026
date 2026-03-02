using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    internal class Delegate
    {
        public void add(int x, int y)
        {
            Console.WriteLine("Addition: " + (x + y));
        }
        public void subtract(int x, int y)
        {
            Console.WriteLine("Subtraction: " + (x - y));
        }
        public void multiply(int x, int y)
        {
            Console.WriteLine("Multiplication: " + (x * y));
        }
        public void division(int x, int y)
        {
            Console.WriteLine("Division: " + (x/y));
        }
    }
}
