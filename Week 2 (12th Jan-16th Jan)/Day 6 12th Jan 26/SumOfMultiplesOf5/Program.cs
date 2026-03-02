namespace SumOfMultiplesOf5
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
                        int output = -1;
                        Console.WriteLine(output);
                        return;
                    }
                }
                int sum = 0; 
                for(int i=0; i<input2; i++)
                {
                    if (input1[i] % 5 == 0)
                    {
                        sum += input1[i];
                    }
                }
                double avg = (double)sum / input2;
                Console.WriteLine("Sum of multiples of 5: " + sum);
                Console.WriteLine("Average: " + avg);
            }
        }
    }
}
