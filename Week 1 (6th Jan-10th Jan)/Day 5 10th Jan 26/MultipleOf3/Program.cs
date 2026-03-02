namespace MultipleOf3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input2, output=0;
            Console.WriteLine("Enter total no of elements: ");
            input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = -2;
            } else { 
                int[] input1 = new int[input2];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output = -1;
                }
            }
            for (int i = 0; i < input2; i++)
            {
                if (input1[i] % 3 == 0)
                {
                    output++;
                }
            }
        }
            Console.WriteLine("Total multiples of 3: " + output);
        }
    }
}
