namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int output;
            if(input < 0)
            {
                output = -1;
                Console.WriteLine("Output: " + output);
            }
            else
            {
                {
                    if(input % 4 == 0 && input % 100 != 0)
                    {
                        Console.WriteLine(input + " is leap year");
                    } else if(input % 400 == 0)
                    {
                        Console.WriteLine(input + " is leap year");
                    } else
                    {
                        output = -2;
                        Console.WriteLine("Output: "+output);
                    }
                }
            }
        }
    }
}
