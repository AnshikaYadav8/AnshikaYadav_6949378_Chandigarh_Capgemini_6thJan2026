using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LuckyNumber
{
    internal class Number
    {
        public bool isPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        public int sum(int m)
        {
            int sum = 0;
            int temp = m;
            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            return sum;
        }
        public int lucky(int input1, int input2)
        {
           int output = 0;
           for (int i = input1; i <= input2; i++)
           {
                isPrime(i);
                if (!isPrime(i))
                {
                    int product = i * i;
                    int s1 = sum(product);
                    int s2 = sum(i);
                    if (s1 == (s2 * s2)) output++;
                }
           }
            return output;
        }   
    }
}
