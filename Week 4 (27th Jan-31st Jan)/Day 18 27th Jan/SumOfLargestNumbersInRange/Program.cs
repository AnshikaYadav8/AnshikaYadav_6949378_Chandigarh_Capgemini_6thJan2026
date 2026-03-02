namespace SumOfLargestNumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            bool neg = false;
            bool range = false;
            if (input1 < 0)
            {
                res = -4;
                Console.WriteLine("Result: " + res);
                return;
            }
            else
            {
                int[] input2 = new int[input1];
                Console.WriteLine("Enter array elements: ");
                for (int i = 0; i < input1; i++)
                {
                    input2[i] = Convert.ToInt32(Console.ReadLine());
                    if (input2[i] < 0)
                    {
                        neg = true;
                    }
                    if (input2[i] == 0 || input2[i] > 100)
                    {
                        range = true;
                    }
                }
                if (neg == true && range == true)
                {
                    res = -3;
                } else if(range == true)
                {
                    res = -2;
                } else if(neg == true)
                {
                    res = -1;
                }
                var arr = input2.Distinct().ToArray();
                int[] output = new int[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 1 || arr[i] > 100)
                        continue;
                    int num = (arr[i] - 1) / 10;
                    if (output[num] < arr[i])
                    {
                        output[num] = arr[i];
                    }
                }
                int sum = 0;
                for (int i = 0; i < output.Length; i++)
                {
                    sum += output[i];
                }
                if (res != 0) Console.WriteLine("Result: "+res);
                else Console.WriteLine("Sum: " + sum);
            }
        }
    }
}
