namespace EnterSubstringAtPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter main string:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter substring:");
            string sub = Console.ReadLine();

            Console.Write("Position: ");
            int pos = int.Parse(Console.ReadLine());

            string res = s.Insert(pos, sub);
            Console.WriteLine(res);
        }
    }
}
