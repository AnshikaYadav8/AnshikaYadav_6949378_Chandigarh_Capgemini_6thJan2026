namespace SumOfFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start no: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int output;
            if(input1 < 0)
            {
                output = -1;
                Console.WriteLine("Output: "+output);
                return;
            }
            Console.WriteLine("Enter end no: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = -3;
                Console.WriteLine("Output: " + output);
                return;
            }
            else if(input2 > 32627)
            {
                output = -2;
                Console.WriteLine("Output: " + output);
                return;
            }
            Console.WriteLine("Enter the number you want sum of factors: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int sum = 0; 
            for(int i=input1; i<=input2; i++)
            {
                if (i % input3 == 0)
                {
                    sum += i;
                }
            }
            output = sum;
            Console.WriteLine("Sum of factors of " + input3 + " is: " + output);
        }
    }
}
