using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class BankAccount
    {
        string Name { get; set; }
        static int AccountNo = 100;
        int Age { get; set; }
        string City { get; set; }
        public int balance = 0;
        public BankAccount()
        {
            Console.WriteLine("Enter Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter City: ");
            this.City = Console.ReadLine();
            AccountNo++;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Account No: " + AccountNo);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("City: " + City);
            Console.WriteLine("Balance: " + balance);
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the amount you want to deposit: ");
            int x = Convert.ToInt32(Console.ReadLine());
            balance += x;
            Console.WriteLine("Balance: " + balance);
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter the amount you want to withdraw: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (balance < x)
            {
                Console.WriteLine("Not enough amount present in account");
            }
            balance -= x;
            Console.WriteLine("Balance: " + balance);
        }
        public virtual void Interest()
        {
            Console.WriteLine("Balance: " + balance);
        }
    }
}
