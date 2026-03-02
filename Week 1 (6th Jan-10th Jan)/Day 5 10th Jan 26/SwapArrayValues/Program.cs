namespace SwapArrayValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input2, res;
            Console.WriteLine("Enter total no of elements: ");
            input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                res = -2;
                Console.WriteLine(res);
            }
            else
            {
                int[] input1 = new int[input2];
                int[] output = new int[input2];
                for (int i = 0; i < input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                    if (input1[i] < 0)
                    {
                        output[0] = -1;
                        Console.WriteLine("Array after swapping elements: ");
                        foreach(int j in output)
                        {
                            Console.WriteLine(j);
                        }
                        return;
                    }
                }
                if(input2 % 2 == 0)
                {
                    output[0] = -3;
                    Console.WriteLine("Array after swapping elements: ");
                    foreach (int j in output)
                    {
                        Console.WriteLine(j);
                    }
                    return;
                }
                int mid = input2 / 2;
                int n = input2;
                for(int i=0; i<mid; i++)
                {
                    int temp = input1[i];
                    input1[i] = input1[n - 1 - i];
                    input1[n - 1 - i] = temp;
                }
                for(int i=0; i<input2; i++)
                {
                    output[i] = input1[i];
                }
                Console.WriteLine("Array after swapping elements: ");
                for (int i = 0; i < input2; i++)
                {
                    Console.WriteLine(output[i]);
                }
            }
        }
    }
}
