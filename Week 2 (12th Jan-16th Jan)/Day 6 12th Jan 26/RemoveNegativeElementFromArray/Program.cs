using System.Xml;

namespace RemoveNegativeElementFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if(input2 < 0)
            {
                int output = -1;
                Console.WriteLine(output);
            }
            else
            {
                int[] input1 = new int[input2];
                int count = 0;
                Console.WriteLine("Enter array elements: ");
                for (int i=0; i<input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                }
                for(int i=0; i<input2; i++)
                {
                    if (input1[i] > 0)
                    {
                        count++;
                    }
                }
                int[] output = new int[count];
                int j = 0;
                for (int i=0; i<input2; i++)
                {
                        if (input1[i] > 0)
                        {
                            output[j] = input1[i];
                        j++;
                        }
                }
                Array.Sort(output);
                Console.WriteLine("Array after removing negative elements: ");
                foreach(int i in output)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
