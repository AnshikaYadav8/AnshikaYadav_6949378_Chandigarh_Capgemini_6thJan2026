namespace PerformOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int output;
            if(input1 < 0)
            {
                output = -1;
                Console.WriteLine(output);
                return;
            }
            Console.WriteLine("Enter 2nd number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = -1;
                Console.WriteLine(output);
                return;
            }
            Console.WriteLine("Enter your choice: 1. Addition 2. Subtraction 3. Multiplication 4. Division");
            int input3 = Convert.ToInt32(Console.ReadLine());
            switch (input3)
            {
                case 1:
                    output = input1 + input2;
                    break;
                case 2:
                    output = input1 - input2;
                    break;
                case 3:
                    output = input1 * input2;
                    break;
                case 4:
                    output = input1 / input2;
                    break;
                default:
                    output = -2;
                    break;
            }
            Console.WriteLine("Output: " + output);
        }
    }
}
