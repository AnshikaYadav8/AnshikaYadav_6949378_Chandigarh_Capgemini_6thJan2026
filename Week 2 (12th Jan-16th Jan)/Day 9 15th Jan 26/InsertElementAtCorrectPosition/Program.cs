namespace InsertElementAtCorrectPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if(input2 < 0)
            {
                int res = -2;
                Console.WriteLine("Output: "+res); 
            } else
            {
                int[] input1 = new int[input2+1];
                Console.WriteLine("Enter array elements: ");
                for(int j=0; j<input2; j++)
                {
                    input1[j] = Convert.ToInt32(Console.ReadLine());
                    if (input1[j] < 0)
                    {
                        int res = -1;
                        Console.WriteLine("Output: "+res);
                        return;
                    }
                }
                Array.Sort(input1,0,input2);
                Console.WriteLine("Enter the element you want to add to array: ");
                int input3 = Convert.ToInt32(Console.ReadLine());
                int pos = 0;
                while (pos < input2 && input1[pos] < input3)
                {
                    pos++;
                }
                for(int i = input2-1; i>=pos; i--)
                {
                    input1[i + 1] = input1[i]; 
                }
                input1[pos] = input3;
                Console.WriteLine("Array elements: ");
                foreach(int j in input1)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
