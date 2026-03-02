namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string: ");
            string input2 = Console.ReadLine();
            RemoveConsonants obj = new RemoveConsonants();
            Console.WriteLine(obj.Consonant(input1, input2));
        }
    }
}
