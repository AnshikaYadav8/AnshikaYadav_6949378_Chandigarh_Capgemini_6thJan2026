namespace Arrays
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 5;
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 20;
            arr[4] = 25;
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}

