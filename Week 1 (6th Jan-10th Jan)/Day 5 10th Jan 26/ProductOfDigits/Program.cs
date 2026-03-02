namespace ProductOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1, output = 1;
            Console.WriteLine("Enter the number: ");
            input1 = Convert.ToInt32(Console.ReadLine());
            if(input1 < 0)
            {
                output = -1;
            } else if(input1 % 3 == 0 || input1 % 5 == 0)
            {
                output = -2;
            } else
            {
                while(input1 > 0)
                {
                    int d = input1 % 10;
                    output *= d;
                    input1 /= 10;
                }
                if(output % 3 == 0 || output % 5 == 0)
                {
                    output = 1;
                }
            }
            Console.WriteLine("Product of digits: "+output);

        }
    }
}
