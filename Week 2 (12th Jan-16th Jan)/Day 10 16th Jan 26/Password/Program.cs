namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of digits: ");
            int input2 = Convert.ToInt32 (Console.ReadLine());
            if(input2 < 0)
            {
                int res = -2;
                Console.WriteLine("Output: "+res);
            }
            else
            {
                Console.WriteLine("Enter the plot numbers");
                int[] input1 = new int[input2];
                for(int i=0; i<input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                    if (input1[i] < 0)
                    {
                        int res = -1;
                        Console.WriteLine("Output: "+res);
                        return;
                    }
                }
                int even = 0, odd = 0;
                for(int i=0; i<input2; i++)
                {
                    if (input1[i] % 2 == 0)
                    {
                        even += input1[i];
                    }
                    else
                    {
                        odd += input1[i];
                    }
                }
                int output = (even + odd) / input2;
                Console.WriteLine("Password: "+output);
            }
        }
    }
}
