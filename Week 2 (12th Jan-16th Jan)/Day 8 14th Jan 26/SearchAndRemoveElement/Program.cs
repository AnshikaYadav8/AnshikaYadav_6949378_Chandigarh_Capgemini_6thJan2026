namespace SearchAndRemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if(input2 < 0)
            {
                int output = -2;
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Enter array elements: ");
                int[] input1 = new int[input2];
                for(int i=0; i<input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                    if (input1[i] < 0)
                    {
                        int res = -1;
                        Console.WriteLine(res);
                        return;
                    }
                }
                Console.WriteLine("What element you want to find?");
                int input3 = Convert.ToInt32(Console.ReadLine());
                    int index = -1;
                    for(int i=0; i<input2; i++)
                    {
                        if (input1[i] == input3)
                        {
                        index = i;
                        break;
                        }
                    }
                if (index == -1)
                {
                    int res = -3;
                    Console.WriteLine(res);
                }
                else
                {
                    int[] output = new int[input2-1];
                    int j = 0;
                    for (int i=0; i<input2; i++)
                    {
                        if (input1[i] != input3)
                        {
                            output[j++] = input1[i];
                        }
                    }
                    Array.Sort(output);
                    Console.WriteLine("Array: ");
                    foreach (int i in output)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
