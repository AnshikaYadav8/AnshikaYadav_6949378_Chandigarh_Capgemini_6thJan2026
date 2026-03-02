namespace SumOfCubes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, output;
            Console.WriteLine("Enter upto which number you want sum of cubes of prime numbers: ");
            input = Convert.ToInt32(Console.ReadLine());
            if(input < 0)
            {
                output = -1;
                Console.WriteLine(output);
            } else if(input > 7)
            {
                output = -2;
                Console.WriteLine(output);
            } else
            {
                int sum = 0;
                for (int i=2; i<=input; i++)
                {
                    bool isprime = true;
                    for (int j = 2; j*j <=i ; j++)
                    {
                        if (i % j == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime)
                    {
                        sum += i*i*i;
                    }
                }
                output = sum;
                Console.WriteLine("Sum of cubes of prime numbers upto "+input+" is: "+output);
            }
        }
    }
}
