using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace TotalMarks
{
    internal class Calculation
    {
        public void calculate(int x, int y, int n1, int n2, int m)
        {
            int a=0, b=0;
            bool found = false;
            for(int i=n1; i>=0; i--)
            {
                int rem = (m - i * x);
                if(rem >= 0 && rem % y == 0)
                {       
                        b = rem / y;
                        a = i;
                    if (b <= n2)
                    {
                        found = true;
                        break;
                    }
                }
            }
            if(found)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(a+" "+b);
            } else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
