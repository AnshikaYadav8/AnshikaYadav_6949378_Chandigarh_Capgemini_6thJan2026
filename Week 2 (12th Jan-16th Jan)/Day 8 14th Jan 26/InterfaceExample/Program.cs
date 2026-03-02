namespace InterfaceExample
{
    interface Inter1
    {
        void f1();
    }
    interface Inter2
    {
        void f1();
    }
    class C : Inter1, Inter2
    {
        void Inter1.f1()
        {
            Console.WriteLine("Interface 1");
        }
        void Inter2.f1()
        {
            Console.WriteLine("Interface 2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            Inter1 i1 = (Inter1)obj;
            Inter2 i2 = obj;
            i1.f1();
            i2.f1();
        }
    }
}
