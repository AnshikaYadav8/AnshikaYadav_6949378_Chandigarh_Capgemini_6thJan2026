namespace CountElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input1 = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            Console.WriteLine("Enter list elements: ");
            for(int i=0; i<input1; i++)
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("Enter a letter: ");
            char input2 = Char.Parse(Console.ReadLine());
            int output = UserProgramCode.getCount(list, input2);
            if(output == -2)
            {
                Console.WriteLine("Only alphabets should be given");
            } else if(output == -1)
            {
                Console.WriteLine("No elements found");
            } else
            {
                Console.WriteLine("Count: " + output);
            }
        }
    }
}
