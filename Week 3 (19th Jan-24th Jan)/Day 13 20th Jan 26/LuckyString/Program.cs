namespace LuckyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter String: ");
            string str = Console.ReadLine();
            StringLucky obj = new StringLucky();
            Console.WriteLine(obj.Checkstring(n, str));
        }
    }
}
