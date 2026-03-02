namespace DigitSumInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            string[] input2 = new string[input1];
            Console.WriteLine("Enter the elements: ");
            for(int i=0; i<input1; i++)
            {
                input2[i] = Console.ReadLine();
            }
            Console.WriteLine("Sum of digits: " + UserProgramCode.digitSum(input2));
        }
    }
}
