namespace SumOfPrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input2, output, sum = 0;
            Console.WriteLine("Enter total no of elements: ");
            input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = -2;
            }
            else
            {
                int[] input1 = new int[input2];
                for (int i = 0; i < input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                    if (input1[i] < 0)
                    {
                        output = -1;
                        Console.WriteLine("Sum of prime numbers: " + output);
                        return;
                    }
                }
                for (int i = 0; i < input2; i++)
                {
                    int num = input1[i];
                    bool isprime = true;
                    if (num <= 1)
                    {
                        isprime = false;
                    }
                    for (int j = 2; j * j <= num; j++)
                    {
                        if (num % j == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime == true)
                    {
                        sum += num;

                    }
                }
                if (sum == 0)
                {
                    output = -3;
                }
                else
                {
                    output = sum;
                }
            }
            Console.WriteLine("Sum of prime numbers: " + output);
        }
    }

}
