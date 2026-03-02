namespace ValidParanthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            Stack<char> st = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    st.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (st.Count == 0)
                    {
                        Console.WriteLine("Not Valid");
                        return;
                    }
                    char top = st.Peek();
                    if (c == ')' && top != '(' || c == ']' && top != '[' || c == '}' && top != '{')
                    {
                        Console.WriteLine("Not Valid");
                        return;
                    }
                    st.Pop();
                }
            }
            if (st.Count == 0) Console.WriteLine("Valid Paranthesis");
            else Console.WriteLine("Not Valid");
        }
    }
}
