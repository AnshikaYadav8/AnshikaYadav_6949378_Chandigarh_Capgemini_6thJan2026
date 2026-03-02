namespace MostRepeated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            int max_count = 1;
            int res = arr[0];
            int cur_count = 1;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                    cur_count++;
                else
                    cur_count = 1;

                if (cur_count > max_count ||
                   (cur_count == max_count && arr[i] > res))
                {
                    max_count = cur_count;
                    res = arr[i];
                }
            }

            Console.WriteLine("Most repeated element is: " + res);
        }
    }
}
