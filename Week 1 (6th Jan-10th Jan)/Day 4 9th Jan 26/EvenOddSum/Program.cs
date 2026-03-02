namespace EvenOddSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter total no of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int output = 0;

            if (arr.Length < 0)
            {
                output = -2;
            }
            else
            {
                int evenSum = 0, oddSum = 0;
                foreach (int x in arr)
                {
                    if (x < 0)
                    {
                        output = -1;
                        Console.WriteLine(output);
                        return;
                    }
                    if (x % 2 == 0) evenSum += x;
                    else oddSum += x;
                }
                output = (evenSum + oddSum) / 2;
            }
            Console.WriteLine("Average of sum of even and odd digits is: "+output);
        }
    }
}
