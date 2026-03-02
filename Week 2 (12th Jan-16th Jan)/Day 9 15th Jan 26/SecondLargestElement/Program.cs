namespace SecondLargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int output;
            if(input2 < 0)
            {
                output = -2;
                Console.WriteLine(output);
            } else
            {
                Console.WriteLine("Enter array elements: ");
                int[] input1 = new int[input2];
                for(int i=0; i<input2; i++)
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
                int max = -1;
                for(int i=0; i<input2; i++)
                {
                    if (input1[i] > max) max = input1[i];
                }
                int sec = -1;
                for(int i=0; i<input2; i++)
                {
                    if (input1[i] > sec && input1[i] < max) sec = input1[i];
                }
                output = sec;
                Console.WriteLine("Second largest element is: " + output);
            }
        }
    }
}
