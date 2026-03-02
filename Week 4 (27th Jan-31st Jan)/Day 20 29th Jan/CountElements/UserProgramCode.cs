using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace CountElements
{
    internal class UserProgramCode
    {
        public static int getCount(List<string>input1, char input2)
        {
            int result = 0;
            for(int i=0; i<input1.Count; i++)
            {
                if (!input1[i].All(Char.IsLetter))
                {
                    result = -2;
                }
            }
            for(int i=0; i<input1.Count; i++)
            {
                if (input1[i].StartsWith(input2))
                {
                    result++;
                }
            }
            if(result == 0) result = -1; 
            return result;
        }
    }
}
