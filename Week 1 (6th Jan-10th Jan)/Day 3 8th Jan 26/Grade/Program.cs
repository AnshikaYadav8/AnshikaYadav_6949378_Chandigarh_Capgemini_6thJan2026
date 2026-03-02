namespace Grade
{
    internal class Grade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of Student: ");
            int x = int.Parse(Console.ReadLine());
            if (x >= 90)
            {
                Console.WriteLine("Grade is A+");
            }
            else if (x >= 80 && x < 90)
            {
                Console.WriteLine("Grade is A");
            }
            else if (x >= 70 && x < 80)
            {
                Console.WriteLine("Grade is B+");
            }
            else if (x >= 60 && x < 70)
            {
                Console.WriteLine("Grade is B");
            }
            else
            {
                Console.WriteLine("Grade is C");
            }
        }
    }
}

