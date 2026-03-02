using System.ComponentModel.Design;

namespace CountOccurence
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
            }
            else
            {
                int[] input1 = new int[input2];
                Console.WriteLine("Enter array elements: ");
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
                    int count = 0;
                    Console.WriteLine("Enter what element you want to search: ");
                    int input3 = Convert.ToInt32(Console.ReadLine());
                    if (input3 < 0)
                    {
                        output = -3;
                        Console.WriteLine(output);
                    }
                    else
                    {
                        for (int i = 0; i < input2; i++)
                        {
                            if (input1[i] == input3)
                            {
                                count++;
                            }
                        }
                        output = count;
                        Console.WriteLine(input3 + " ocuured " + output + " times");
                    }
                }
        }
    }
}
