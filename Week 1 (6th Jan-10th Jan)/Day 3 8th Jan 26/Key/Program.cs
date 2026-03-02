namespace Key
{
    internal class Key
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Press a key!");
            x = Console.ReadLine();
            switch (x)
            {
                case "0":
                    Console.WriteLine("Key pressed is 0");
                    break;
                case "1":
                    Console.WriteLine("Key pressed is 1");
                    break;
                case "2":
                    Console.WriteLine("Key pressed is 2");
                    break;
                case "3":
                    Console.WriteLine("Key pressed is 3");
                    break;
                case "4":
                    Console.WriteLine("Key pressed is 4");
                    break;
                case "5":
                    Console.WriteLine("Key pressed is 5");
                    break;
                case "6":
                    Console.WriteLine("Key pressed is 6");
                    break;
                case "7":
                    Console.WriteLine("Key pressed is 7");
                    break;
                case "8":
                    Console.WriteLine("Key pressed is 8");
                    break;
                case "9":
                    Console.WriteLine("Key pressed is 9");
                    break;
                default:
                    Console.WriteLine("Invalid!");
                    break;
            }
        }
    }
}







