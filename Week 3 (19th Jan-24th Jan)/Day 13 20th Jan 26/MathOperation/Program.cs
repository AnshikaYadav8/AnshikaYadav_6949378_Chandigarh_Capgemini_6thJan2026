namespace MathOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            MinOperation obj = new MinOperation();
            int result = obj.Minsteps(n);
            Console.WriteLine(result);
        }
    }
}
