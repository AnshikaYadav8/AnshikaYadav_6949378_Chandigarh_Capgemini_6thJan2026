using System.Security.Cryptography.X509Certificates;

namespace DelegateExample
{
    internal class Program
    {
        public delegate void Math(int x, int y);
        static void Main(string[] args)
        {

            Delegate obj = new Delegate();
            Math m = new Math(obj.add);
            m += obj.subtract;
            m += obj.multiply;
            m += obj.division;
            m(100, 50);
            Console.WriteLine();
            m -= obj.add;
            m(5, 10);
            Console.WriteLine();
        }
    }
}
