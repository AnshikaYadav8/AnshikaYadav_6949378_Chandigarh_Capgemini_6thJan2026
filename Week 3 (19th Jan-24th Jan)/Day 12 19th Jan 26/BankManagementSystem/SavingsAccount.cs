using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class SavingsAccount: BankAccount
    {
        override public void Interest()
        {
            double rate = 4;
            double interest = (balance * rate * 1) / 100;
            Console.WriteLine("Yearly Interest: "+interest);
        }
    }
}
