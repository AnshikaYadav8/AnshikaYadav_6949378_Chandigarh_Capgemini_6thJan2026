namespace Rupees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Rupee Value: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = 0;
            if(input < 0)
            {
                output = -1;
                Console.WriteLine(output);
            }
            else
            {
                int[] notes = { 500, 100, 50, 10, 1 };
                foreach(int i in notes)
                {
                    int count = input/i;
                    if (count > 0)
                    {
                        output += count;
                        input %= i;
                    }
                }
                Console.WriteLine("Total notes used: " + output);
            }
        }
    }
}
