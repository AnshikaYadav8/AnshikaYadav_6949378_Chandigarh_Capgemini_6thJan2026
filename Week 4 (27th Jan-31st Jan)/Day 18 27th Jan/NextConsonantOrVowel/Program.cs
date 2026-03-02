using System.Text;

namespace NextConsonantOrVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            if (!input.All(char.IsLetter))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            StringBuilder output = new StringBuilder();
            foreach(char c in input)
            {
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    output.Append((char)(c + 1));
                } else if(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    output.Append((char)(c + 1));
                }
                else
                {
                    if (char.IsUpper(c) == false)
                    {
                        if (c < 'e')
                        {
                            output.Append('e');
                        }
                        else if (c < 'i')
                        {
                            output.Append('i');
                        }
                        else if (c < 'o')
                        {
                            output.Append('o');
                        }
                        else if (c < 'u')
                        {
                            output.Append('u');
                        }
                        else
                        {
                            output.Append('a');
                        }
                    } else
                    {
                        if (c < 'E')
                        {
                            output.Append('E');
                        }
                        else if (c < 'I')
                        {
                            output.Append('I');
                        }
                        else if (c < 'O')
                        {
                            output.Append('O');
                        }
                        else if (c < 'U')
                        {
                            output.Append('U');
                        }
                        else
                        {
                            output.Append('A');
                        }
                    }
                }
            }
            Console.WriteLine(output.ToString());
        }
    }
}
