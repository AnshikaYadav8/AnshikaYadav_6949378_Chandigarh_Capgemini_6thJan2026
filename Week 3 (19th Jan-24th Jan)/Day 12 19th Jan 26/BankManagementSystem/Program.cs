namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the choice for account type- 1. Savings Account 2. Checking Account");
            int input1 = Convert.ToInt32(Console.ReadLine());
            switch (input1)
            {
                case 1:
                    SavingsAccount obj1 = new SavingsAccount();
                    while (obj1 != null)
                    {
                        Console.WriteLine("1. Deposit money 2. Withdraw Money 3. Display Account Details 4. Interest Details 5. Exit");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        switch (input2)
                        {
                            case 1:
                                obj1.Deposit();
                                break;
                            case 2:
                                obj1.Withdraw();
                                break;
                            case 3:
                                obj1.Display();
                                break;
                            case 4:
                                obj1.Interest();
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                    }
                    break;
                case 2:
                    CheckingAccount obj2 = new CheckingAccount();
                    while (obj2 != null)
                    {
                        Console.WriteLine("1. Deposit money 2. Withdraw Money 3. Display Account Details 4. Interest Details 5. Exit");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        switch (input2)
                        {
                            case 1:
                                obj2.Deposit();
                                break;
                            case 2:
                                obj2.Withdraw();
                                break;
                            case 3:
                                obj2.Display();
                                break;
                            case 4:
                                obj2.Interest();
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
