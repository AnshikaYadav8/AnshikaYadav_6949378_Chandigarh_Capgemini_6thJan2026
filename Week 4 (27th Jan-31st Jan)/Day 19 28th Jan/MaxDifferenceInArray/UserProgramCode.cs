using System;
using System.Collections.Generic;
using System.Text;

namespace MaxDifferenceInArray
{
    internal class UserProgramCode
    {
        public static int diffIntArray(int[] input1)
        {
            int diff = 0;
            for(int i=0; i<input1.Length; i++)
            {
                for(int j=i+1; j<input1.Length; j++)
                {
                    diff = Math.Max(diff, input1[j] - input1[i]);
                }
            }
            return diff;
        }
    }
}
