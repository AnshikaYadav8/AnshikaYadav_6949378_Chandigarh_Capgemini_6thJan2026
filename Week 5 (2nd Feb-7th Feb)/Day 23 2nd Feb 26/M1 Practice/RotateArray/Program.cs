namespace RotateArray
{
    internal class Program
    {
        static int[] rotateArray(int[] arr, int n, int k)
        {
            k = k % n;
            Array.Reverse(arr);
            Array.Reverse(arr, 0, k);
            Array.Reverse(arr, k, n - k);
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array elements:");
            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter by how much elements you want to rotate the array:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rotated Array: " + string.Join(" ",rotateArray(arr, n, k)));
        }
    }
}
