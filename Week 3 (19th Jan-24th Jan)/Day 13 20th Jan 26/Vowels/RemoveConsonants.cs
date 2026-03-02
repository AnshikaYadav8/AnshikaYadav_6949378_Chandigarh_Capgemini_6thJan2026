using System;
using System.Collections.Generic;
using System.Text;

namespace Vowels
{
    internal class RemoveConsonants
    {
        public string Consonant(string input1, string input2)
        {
            HashSet<char> consonant = new HashSet<char>();
            StringBuilder output = new StringBuilder();
            foreach (char c in input2.ToLower())
            {
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                {
                    consonant.Add(c);
                }
            }
            StringBuilder result = new StringBuilder();
            foreach (char c in input1)
            {
                if (!consonant.Contains(char.ToLower(c)))
                {
                    result.Append(c);
                }
            }
            output.Append(result[0]);
            for(int i=1; i<result.Length; i++)
            {
                if (char.ToLower(result[i-1]) != char.ToLower(result[i]))
                {
                    output.Append(result[i]);
                }
            }
            return output.ToString(); 
        }
    }
}
