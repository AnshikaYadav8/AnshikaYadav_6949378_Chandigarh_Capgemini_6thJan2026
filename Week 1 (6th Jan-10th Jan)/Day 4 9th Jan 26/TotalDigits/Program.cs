namespace TotalDigits
{ 
    internal class Digit
    {
        static void Main(string[] args)
        {
            int num, output, count = 0;
            Console.WriteLine("Enter a num: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                output = -1;
            }
            else if(num == 0)
            {
                output = 1;
            } else {
                while (num > 0)
                {
                    count++;
                    num = num / 10;
                }
                output = count;
            }
            Console.WriteLine("Total digits are: " + output);
        }
    }
}
