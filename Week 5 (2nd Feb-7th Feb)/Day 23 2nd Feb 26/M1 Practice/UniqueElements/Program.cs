namespace UniqueElements
{
    internal class Program
    {
        static int uniqueElements(int[] input)
        {
            int j = 0;
            for(int i=1; i<input.Length; i++)
            {
                if (input[i] != input[j])
                {
                    j++;
                    input[j] = input[i];
                }
            }
            return j + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] input2 = new int[input1];
            for(int i=0; i<input1; i++)
            {
                input2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("No of Unique Elements: " + uniqueElements(input2));
        }
    }
}
