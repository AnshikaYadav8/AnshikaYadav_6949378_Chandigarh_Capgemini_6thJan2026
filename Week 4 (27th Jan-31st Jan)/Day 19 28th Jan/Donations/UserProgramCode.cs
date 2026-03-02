using System;
using System.Collections.Generic;
using System.Text;

namespace Donations
{
    internal class UserProgramCode
    {
        public static int getDonation(string[] input2, int input3)
        {
            string str = Convert.ToString(input3);
            int sum = 0;
            for(int i=0; i<input2.Length; i++)
            {
                string usercode = input2[i].Substring(0, 3);
                string location = input2[i].Substring(3, 3);
                string donation = input2[i].Substring(6, 3);
                if(location == str)
                {
                    sum += Convert.ToInt32(donation);
                }
            }
            return sum;
        }
    }
}
