namespace SearchElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output;
            Console.WriteLine("Enter total number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                output = -2;
                Console.WriteLine(output);
                return;
            }
            int[] arr = new int[n];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] < 0)
                {
                    output = -1;
                    Console.WriteLine(output);
                    return;
                }
            }
            Console.WriteLine("Enter element to search:");
            int key = Convert.ToInt32(Console.ReadLine());
            output = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == key)
                {
                    output = 1;
                    break;
                }
                else
                {
                    output = -3;
                }
            }
            Console.WriteLine("Element is found at position: " + output);
        }
    }
}
