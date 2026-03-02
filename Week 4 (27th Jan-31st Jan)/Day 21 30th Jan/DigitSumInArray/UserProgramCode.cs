using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSumInArray
{
    internal class UserProgramCode
    {
        public static int digitSum(string[] input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                foreach (char c in input[i])
                {
                    if (Char.IsLetter(c) && Char.IsDigit(c))
                    {
                        return -1;
                    }
                }
            }
            for (int i=0; i<input.Length; i++)
            {
                foreach(char c in input[i])
                {
                    if (Char.IsDigit(c))
                    {
                        result += Convert.ToInt32(c.ToString());
                    }
                }
            }
            return result;
        } 
    }
}
