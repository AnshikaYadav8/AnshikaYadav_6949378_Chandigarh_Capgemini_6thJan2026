namespace GrossSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base salary: ");
            double input = Convert.ToDouble(Console.ReadLine());   
            double output, da, hra;
            if(input < 0)
            {
                output = -1;
                Console.WriteLine(output);
            } else if(input > 10000)
            {
                output = -2;
                Console.WriteLine(output);
            } else
            {
                da = 0.75 * input;
                hra = 0.5 * input;
                output = input + da + hra;
                Console.WriteLine("Gross Salary: "+output);  
            }
        }
    }
}
