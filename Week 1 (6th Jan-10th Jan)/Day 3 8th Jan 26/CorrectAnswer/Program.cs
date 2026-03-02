namespace CorrectAnswer
{
    internal class CorrectAnswer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Int is of how many bits?");
            string a = "1 bit";
            string b = "2 bits";
            string c = "3 bits";
            string d = "4 bits";
            Console.WriteLine("1- " + a + " 2- " + b + " 3- " + c + " 4- " + d);
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Wrong Answer!");
                    break;
                case 2:
                    Console.WriteLine("Wrong Answer!");
                    break;
                case 3:
                    Console.WriteLine("Wrong Answer!");
                    break;
                case 4:
                    Console.WriteLine("Correct Answer!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}

