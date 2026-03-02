using System;
using System.Collections.Generic;
using System.Text;

namespace ListTheElements
{
    internal class UserProgramCode
    {
        public static List<int> getElements(List<int> input2, int input3)
        {
            List<int> output = new List<int>();
            for(int i=0; i<input2.Count; i++)
            {
                if (input2[i] < input3)
                {
                    output.Add(input2[i]);
                }
            }
            return output;
        }
    }
}
