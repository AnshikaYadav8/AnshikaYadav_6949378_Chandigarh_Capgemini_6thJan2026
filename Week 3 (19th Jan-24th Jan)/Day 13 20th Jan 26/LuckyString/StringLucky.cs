using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyString
{
    internal class StringLucky
    {
        public string Checkstring(int n, string str)
        {
            if (n > str.Length)
                return "Invalid";

            int half = n / 2;

            for (int i = 0; i <= str.Length - n; i++)
            {
                string sub = str.Substring(i, n);

                foreach (char c in sub)
                {
                    if (c != 'P' && c != 'S' && c != 'G')
                        goto NextSubstring;
                }

                int count = 1;
                for (int j = 1; j < sub.Length; j++)
                {
                    if (sub[j] == sub[j - 1])
                    {
                        count++;
                        if (count >= half)
                            return "Yes";
                    }
                    else
                    {
                        count = 1;
                    }
                }
            NextSubstring:;
            }
            return "No";
        }
    }
}
