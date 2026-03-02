namespace GreaterElementOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int[] arr3 = new int[n];
            Console.WriteLine("Enter elements of 1st array: ");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                if (arr1[i] < 0)
                {
                    arr3[0] = -1;
                    foreach (int x in arr3)
                    {
                        Console.WriteLine(x);
                    }
                    return;
                }
            }
            Console.WriteLine("Enter elements of 2nd array: ");
            for (int i = 0; i < n; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
                if (arr1[i] < 0)
                {
                    arr3[0] = -1;
                    foreach (int x in arr3)
                    {
                        Console.Write(x);
                    }
                    return;
                }
            }
            for(int i=0; i<n; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    arr3[i] = arr1[i];
                } else
                {
                    arr3[i] = arr2[i];
                }
            }
            Console.WriteLine("Gretaer element of 2 arrays: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}
