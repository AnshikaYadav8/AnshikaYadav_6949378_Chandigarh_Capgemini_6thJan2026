namespace BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary Number: ");
            string input = Console.ReadLine();
            int output = 0;
            if (input.Length > 5)
            {
                output = -2;
                Console.WriteLine(output);
                return;
            }
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    output = -1;
                    Console.WriteLine(output);
                    return;
                }
            }
                int binary = Convert.ToInt32(input);
                int power = 0;
                while (binary != 0)
                {
                    int bit = binary % 10;
                    output += bit * (int)Math.Pow(2, power);
                    binary /= 10;
                    power++;
                }
                Console.WriteLine(output);
        }
    }
}




