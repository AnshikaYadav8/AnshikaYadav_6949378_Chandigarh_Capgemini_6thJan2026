namespace FarenheitToCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, output;
            Console.WriteLine("Enter temperature in Farenheit: ");
            input = Convert.ToInt32(Console.ReadLine());
            if(input < 0)
            {
                output = -1;
                Console.WriteLine("Temperature in Celsius: " + output);
            } else
            {
                output = (input - 32) * 5 / 9;
                Console.WriteLine("Temperature in Celsius: " + output);
            }
        }
    }
}
