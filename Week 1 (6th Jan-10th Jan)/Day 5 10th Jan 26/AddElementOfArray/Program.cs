using System.Xml;

namespace AddElementOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input3;
            Console.WriteLine("Enter total no of elements: ");
            input3 = Convert.ToInt32(Console.ReadLine());
            if (input3 < 0)
            {
                int res = -2;
                Console.WriteLine(res);
            } else
            {
                int[] input1 = new int[input3];
                int[] input2 = new int[input3];
                int[] output = new int[input3];
                Console.WriteLine("Enter elements of 1st array: ");
                for (int i=0; i<input3; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                    if (input1[i] < 0)
                    {
                        output[0] = -1;
                        Console.WriteLine("Elements after addition: ");
                        foreach(int j in output)
                        {
                            Console.WriteLine(j);
                        }
                        return;
                    }
                }
                Console.WriteLine("Enter elements of 2nd array: ");
                for (int i = 0; i < input3; i++)
                {
                    input2[i] = Convert.ToInt32(Console.ReadLine());
                    if (input2[i] < 0)
                    {
                        output[0] = -1;
                        Console.WriteLine("Elements after addition: ");
                        foreach (int j in output)
                        {
                            Console.WriteLine(j);
                        }
                        return;
                    }
                }
                for(int i=0; i<input3; i++)
                {
                    for(int j=input3-1; j>0; j--)
                    {
                        output[i] = input1[i] + input2[j];
                    }
                }
                foreach (int j in output)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
