using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace EmployeeDesignation
{
    internal class UserProgramCode
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            List<string> result = new List<string>();
            string designation = input1[1];
            bool allSame = true;
            for(int i=1; i<input1.Length; i+=2)
            {
                if(designation.ToLower() != input1[i].ToLower())
                {
                    allSame = false;
                    break;
                }
            }
            if (allSame == true)
            {
                return new string[] { "All employees belong to " + input2 + " designation" };
            } 
            for(int i=1; i<input1.Length; i+=2)
            {
                if (input1[i].ToLower() == input2.ToLower())
                {
                    result.Add(input1[i - 1]);
                }
            }
            if(result.Count == 0)
            {
                return new string[] { "No employee for " + input2 + " designation" };
            }
            return result.ToArray();
        }
    }
}
