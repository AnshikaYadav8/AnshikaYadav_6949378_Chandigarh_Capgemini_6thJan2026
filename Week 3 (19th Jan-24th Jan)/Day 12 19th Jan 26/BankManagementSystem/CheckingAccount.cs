using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class CheckingAccount: BankAccount
    {
        public override void Interest()
        {
            Console.WriteLine("Checking account is zero interest account!");
        }
    }
}
