namespace Donations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of people: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            string[] input2 = new string[input1];
            Console.WriteLine("Enter codes: ");
            for(int i=0; i<input1; i++)
            {
                input2[i] = Console.ReadLine();
                if (input2[i].Length > 9)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }
            Console.WriteLine("Enter location code: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Donations: "+UserProgramCode.getDonation(input2, input3));
        }
    }
}
