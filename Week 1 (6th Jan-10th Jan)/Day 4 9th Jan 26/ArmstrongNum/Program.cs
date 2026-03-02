namespace ArmstrongNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int output;

            if (num < 0)
                output = -1;
            else if (num > 999)
                output = -2;
            else
            {
                int temp = num, sum = 0;
                while (temp > 0)
                {
                    int d = temp % 10;
                    sum += d * d * d;
                    temp /= 10;
                }
                if(sum == num)
                {
                    output = 1;
                } else
                {
                    output = 0;
                }
            }
            Console.WriteLine(output);
        }
    }
}
