using System.Security.Cryptography.X509Certificates;

namespace TargetSum
{
    internal class Program
    {
        static int[] targetSum(int[] input1, int input2)
        {
            for (int i = 0; i < input1.Length; i++)
            {
                int complement = input2 - input1[i];
                for (int j = i + 1; j < input1.Length; j++)
                {
                    if (input1[j] == complement)
                    {
                        return new int[] { input1[i], input1[j] };
                    }
                }
            }
            return new int[] { -1 };
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter total no of elements:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int[] input2 = new int[input1];
            Console.WriteLine("Enter the elements:");
            for(int i=0; i<input1; i++)
            {
                input2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter target:");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int[] result = targetSum(input2, input3);
            if (result[0] == -1) Console.WriteLine("No pair found with values equal to target");  
            else Console.WriteLine($"Result: { result[0]},{ result[1]}");
        }
    }
}
