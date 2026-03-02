using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceString
{
    internal class UserProgramCode
    {
        public static string replaceString(string input1, int input2, char input3)
        {
            string output = "";
            string[] str = input1.Split(' ');
            if(input2 >= 1 && input2 <= str.Length)
            {
                str[input2 - 1] = Regex.Replace(str[input2 - 1], ".", input3.ToString());
                output += string.Join(" ", str);
                output = output.ToLower();
            } else
            {
                return "-4";
            }
                return output;
        }
    }
}
