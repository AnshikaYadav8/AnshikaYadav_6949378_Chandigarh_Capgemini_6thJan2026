namespace ListTheElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of elements: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input <= 0)
            {
                int res = -1;
                Console.WriteLine(res);
                return;
            }
            Console.WriteLine("Enter the elements: ");
            List<int> input2 = new List<int>();
            for(int i=0; i<input; i++)
            {
                input2.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Enter the number: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            List<int> result = UserProgramCode.getElements(input2, input3);
            if (result.Count == 0) Console.WriteLine("No elements found");
            else Console.WriteLine("Elements smaller than " + input3 + " are: " + string.Join(",",result));
        }
    }
}
