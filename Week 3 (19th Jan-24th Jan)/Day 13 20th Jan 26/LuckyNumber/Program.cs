namespace LuckyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Number obj = new Number();
            Console.WriteLine(obj.lucky(input1, input2));
        }
    }
}
