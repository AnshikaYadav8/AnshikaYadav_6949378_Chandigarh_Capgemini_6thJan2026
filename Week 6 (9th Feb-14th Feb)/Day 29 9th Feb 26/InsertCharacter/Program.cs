namespace InsertCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the position at which you want to insert new character:");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the character:");
            char ch = Convert.ToChar(Console.ReadLine());
            string result = input.Insert(pos, ch.ToString());
            Console.WriteLine("New String: "+result);
        }
    }
}
