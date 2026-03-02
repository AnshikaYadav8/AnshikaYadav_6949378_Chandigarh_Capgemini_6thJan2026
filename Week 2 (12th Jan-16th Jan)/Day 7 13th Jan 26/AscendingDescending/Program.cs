namespace AscendingDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if(input2 < 0)
            {
                int output = -1;
                Console.WriteLine(output);
            }
            else
            {
                int[] input1 = new int[input2];
                Console.WriteLine("Enter array elements: ");
                for(int i=0; i<input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(input1);
                int mid = input2 / 2;
                int[] output = new int[input2];
                for(int i=0; i<mid; i++)
                {
                    output[i] = input1[i];
                } 
                int index = mid;
                for(int i=input2-1; i>=mid; i--)
                {
                    output[index++] = input1[i];
                }
                Console.WriteLine("Array: ");
                foreach(int i in output)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
