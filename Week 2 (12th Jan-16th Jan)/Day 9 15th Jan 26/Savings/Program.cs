namespace Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2;
            double output, food, travel, expense;
            if (input1 > 9000)
            {
                output = -1;
                Console.WriteLine(output);
            }
            else if (input1 < 0)
            {
                output = -2;
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Enter total days worked: ");
                input2 = Convert.ToInt32(Console.ReadLine());
                if(input2 < 0)
                {
                    output = -4;
                    Console.WriteLine(output);
                }
                else
                {
                    if (input2 == 31)
                    {
                        input1 = input1 + 500;
                        food = input1*0.5 ;
                        travel = input1*0.2;
                        expense = food + travel;
                        output = input1 - expense;
                        Console.WriteLine("Savings: " + output);
                    }
                    else if(input2 < 31)
                    {
                        food = input1*0.5;
                        travel = input1*0.2;
                        expense = food + travel;
                        output = input1 - expense;
                        Console.WriteLine("Savings: " + output);
                    }
                }
            }
        }
    }
}
