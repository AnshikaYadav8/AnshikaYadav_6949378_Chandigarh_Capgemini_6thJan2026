namespace MaximumDeletionOfConsecutivePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();
            Stack<char> st = new Stack<char>();
            int count = 0;
            foreach(char c in input)
            {
                if (st.Count > 0 && st.Peek() == c)
                {
                    st.Pop();
                    count++;
                }
                else st.Push(c);
            }
            Console.WriteLine(count);
        }
    }
}
