namespace Sort
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
            for(int i=0; i<n; i++)
            { 
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                if (arr1[i] < 0)
                {
                    arr3[0] = -1;
                    foreach(int x in arr3)
                    {
                        Console.WriteLine(x);
                    }
                    return;
                }
            }
            Array.Sort(arr1);
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
            Array.Sort(arr2);
            int a = 0, b = n - 1, c = 0;
            while (a < n)
            {
                arr3[c] = arr1[a] * arr2[b];
                a++;
                b--;
                c++;
            }
            Console.WriteLine("Array elemets after multiplication: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}
