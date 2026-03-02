using System;
using System.Collections.Generic;
using System.Text;

namespace FormString
{
    internal class UserProgramCode
    {
        public static string formString(string[] input1, int input2)
        {
            string result = "";
            for(int i=0; i<input1.Length; i++)
            {
                foreach(char c in input1[i])
                {
                    if(!Char.IsLetter(c) && !Char.IsDigit(c))
                    {
                        return "-1";
                    }
                }
            }
            foreach(string s in input1)
            {
                if (input2 <= s.Length)
                {
                    result += s[input2-1];
                }
                else result += '$';
            }
            return result;
        }
    }
}
