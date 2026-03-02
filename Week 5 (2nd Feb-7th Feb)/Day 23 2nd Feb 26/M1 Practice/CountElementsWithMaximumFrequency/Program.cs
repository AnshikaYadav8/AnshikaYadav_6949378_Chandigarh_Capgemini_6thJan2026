namespace CountElementsWithMaximumFrequency
{
    internal class Program
    {
        static int maxFrequency(int[] input)
        {
            Dictionary<int,int> freq = new Dictionary<int,int>();
            foreach (int val in input) {
                if (freq.ContainsKey(val))
                {
                    freq[val]++;
                } else
                {
                    freq[val] = 1;
                }
            }
            int result = 0;
            int maxFreq = freq.Values.Max();
            foreach(int val in freq.Values)
            {
                if(val == maxFreq)
                {
                    result += val;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int[] input2 = new int[input1];
            Console.WriteLine("Enter array elements:");
            for(int i=0; i<input1; i++)
            {
                input2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:"+ maxFrequency(input2));
        }
    }
}
