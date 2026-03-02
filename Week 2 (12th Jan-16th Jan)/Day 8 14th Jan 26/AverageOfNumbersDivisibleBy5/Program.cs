namespace AverageOfNumbersDivisibleBy5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, output;
            Console.WriteLine("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            if(input < 0)
            {
                output = -1;
                Console.WriteLine(output);
            } else
            {
                int sum = 0;
                for(int i=0; i<=input; i++)
                {
                    if (i % 5 == 0)
                    {
                        sum += i; 
                    }
                }
                double avg = (double)sum / input;
                Console.WriteLine("Average: " + avg);
            }
        }
    }
}
