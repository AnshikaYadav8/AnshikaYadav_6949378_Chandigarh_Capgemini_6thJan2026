using System.Runtime.InteropServices;

namespace TotalCouples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            for(int i=1; i<n; i++)
            {
                int sum = arr[i] + arr[i - 1];
                if(sum % n == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Total number of couples: "+count);
        }
    }
}
