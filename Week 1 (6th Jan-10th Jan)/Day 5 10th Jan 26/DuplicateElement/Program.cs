namespace DuplicateElement
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
                int[] input1 = new int[input2];
                int[] output = new int[input2];
                Console.WriteLine("Enter elements of array: ");
                for(int i=0; i<input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                    if (input1[i] < 0)
                    {
                        output[0] = -1;
                        Console.WriteLine("Array after removing duplicates: ");
                        foreach(int j in output)
                        {
                            Console.WriteLine(j);
                        }
                        return;
                    }
                }
                Array.Sort(input1);
                Console.WriteLine(input1[0]);
                for(int i=1; i<input2; i++)
                {
                    if (input1[i] != input1[i - 1])
                    {
                        Console.WriteLine(input1[i]);
                    }
                }
            }
        }
    }
}
