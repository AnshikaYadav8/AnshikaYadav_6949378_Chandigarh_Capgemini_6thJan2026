using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace IsNot
{
    internal class UserProgramCode
    {
        public static string negativeString(string input)
        {
            string output = Regex.Replace(input, @"\bis\b", "is not");
            return output;
        }
    }
}
