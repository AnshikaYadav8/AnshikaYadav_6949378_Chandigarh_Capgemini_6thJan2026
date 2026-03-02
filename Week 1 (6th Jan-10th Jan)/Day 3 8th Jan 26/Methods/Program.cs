namespace Methods
{
    internal class Method
    {
        void Test()
        {
            Console.WriteLine("This is method 1");
        }
        void Test1(int x)
        {
            Console.WriteLine("This is method 2" + x);
        }
        string Test2()
        {
            return "This is method 3";
        }
        string Test3(string name)
        {
            return "Hello" + name;
        }

        void Math1(int x, int y, ref int m, ref int n)
        {
            m = x + y;
            n = x * y;
        }

        void Math2(int x, int y, out int a, out int b)
        {
            a = x - y;
            b = x / y;
        }

        static void Main(string[] args)
        {
            int x = 8;
            string name = "Anshika";
            Method p = new Method();
            p.Test();
            p.Test1(x);
            Console.WriteLine(p.Test2());
            Console.WriteLine(p.Test3(name));
            int m = 0, n = 0;
            p.Math1(100, 50, ref m, ref n);
            Console.WriteLine(m + " " + n);
            int a, b;
            p.Math2(100, 50, out a, out b);
            Console.WriteLine(a + " " + b);

        }

    }
}





