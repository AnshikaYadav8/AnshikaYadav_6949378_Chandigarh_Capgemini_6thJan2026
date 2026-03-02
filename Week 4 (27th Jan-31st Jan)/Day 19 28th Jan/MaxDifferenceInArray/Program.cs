namespace MaxDifferenceInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers: ");
            int[] input = new int[size];
            int res = 0;
            for(int i=0; i<size; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
                if (input[i] < 0)
                {
                    res = -1;
                    Console.WriteLine("Result: " + res);
                    return;
                }
            }
            if(input.Count() == 1 || input.Count() > 10)
            {
                res = -2;
                Console.WriteLine("Result: " + res);
                return;
            }
            if(input.Count() != input.Distinct().Count())
            {
                res = -3;
                Console.WriteLine("Result: " + res);
                return;
            }
            Console.WriteLine("Maximum Difference: "+UserProgramCode.diffIntArray(input));
        }
    }
}
