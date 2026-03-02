namespace ProductOfMinimumAndMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int output;
            if (input2 < 0)
            {
                output = -2;
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Enter array elements: ");
                int[] input1 = new int[input2];
                for (int i = 0; i < input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                    if (input1[i] < 0)
                    {
                        output = -1;
                        Console.WriteLine(output);
                        return;
                    }
                }
                Array.Sort(input1);
                int min = input1[0];
                int max = input1[input2 - 1];
                output = min * max;
                Console.WriteLine("Product of minimum and maximum element: "+output);
            }
        }
    }
}
