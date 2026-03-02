namespace MultiplyPositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = 1;
            Console.WriteLine("Enter total number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                output = -2;
                Console.WriteLine(output);
                return;
            }
            int[] arr = new int[n];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] > 0)
                {
                    output *= arr[i];
                }
            }
            Console.WriteLine("Multiplication of positive numbers: "+output);
        }
    }
}
