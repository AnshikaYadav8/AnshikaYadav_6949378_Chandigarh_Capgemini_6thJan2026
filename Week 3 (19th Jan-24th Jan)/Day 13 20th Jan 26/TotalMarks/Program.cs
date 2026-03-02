namespace TotalMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marks awarded for correct answers of type 1 questions: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks awarded for correct answers of type 2 questions: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No of questions of type 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No of questions of type 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Marks: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Calculation obj = new Calculation();
            obj.calculate(x, y, n1, n2, m);
        }
    }
}
